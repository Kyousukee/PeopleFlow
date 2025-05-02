using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeopleFlow.BO
{
    public class Validaciones
    {
        // Definición de los arreglos de palabras
        private static readonly string[] unidades = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };
        private static readonly string[] especiales = { "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciséis", "Diecisiete", "Dieciocho", "Diecinueve" };
        private static readonly string[] decenas = { "", "", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa" };
        private static readonly string[] centenas = { "", "Cien", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos" };

        // Validar si un campo está vacío
        public static bool ValidarRequerido(string valor, string nombreCampo, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                mensajeError = $"El campo {nombreCampo} es requerido.";
                return false;
            }
            mensajeError = "";
            return true;
        }
        public static bool ValidarRut(string rut)
        {
            // Expresión regular para validar el formato del RUT
            if (!Regex.IsMatch(rut, @"^\d{1,8}-[\dkK]$"))
                return false;

            // Separar el número del dígito verificador
            string[] partes = rut.Split('-');
            string numero = partes[0];
            string dv = partes[1].ToUpper(); // Convertir a mayúscula para manejar 'k' o 'K'

            // Calcular el dígito verificador esperado
            int suma = 0;
            int multiplicador = 2;

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                suma += int.Parse(numero[i].ToString()) * multiplicador;
                multiplicador = multiplicador == 7 ? 2 : multiplicador + 1;
            }

            int resto = suma % 11;
            string dvEsperado = (11 - resto).ToString();

            if (dvEsperado == "11") dvEsperado = "0";
            if (dvEsperado == "10") dvEsperado = "K";

            // Comparar el dígito verificador calculado con el proporcionado
            return dv == dvEsperado;
        }

        public static bool ValidarCorreo(string correo)
        {
            // Expresión regular para validar el formato del correo
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(correo, patron);
        }

        public static void SoloNumeros(TextBox textBox, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        public static string ConvertirNumeroATexto(decimal numero)
        {
            if (numero == 0)
                return "Cero";

            string texto = "";

            // Parte entera del número
            long parteEntera = (long)numero;

            // Convertir la parte entera
            if (parteEntera > 0)
                texto += ConvertirParteEntera(parteEntera);

            // Parte decimal (máximo 2 decimales)
            int parteDecimal = (int)((numero - parteEntera) * 100);
            if (parteDecimal > 0)
                texto += " con " + ConvertirParteEntera(parteDecimal);

            return texto.Trim();
        }

        private static string ConvertirParteEntera(long numero)
        {
            if (numero < 10)
                return unidades[numero];

            if (numero < 20)
                return especiales[numero - 10];

            if (numero < 100)
            {
                int decena = (int)(numero / 10);
                int unidad = (int)(numero % 10);
                return decenas[decena] + (unidad > 0 ? " y " + unidades[unidad] : "");
            }

            if (numero < 1000)
            {
                int centena = (int)(numero / 100);
                int resto = (int)(numero % 100);
                return (centena == 1 && resto > 0 ? "Ciento" : centenas[centena]) + (resto > 0 ? " " + ConvertirParteEntera(resto) : "");
            }

            if (numero < 1_000_000)
            {
                long miles = numero / 1000;
                long resto = numero % 1000;
                return (miles == 1 ? "Mil" : ConvertirParteEntera(miles) + " mil") + (resto > 0 ? " " + ConvertirParteEntera(resto) : "");
            }

            if (numero < 1_000_000_000)
            {
                long millones = numero / 1_000_000;
                long resto = numero % 1_000_000;
                return (millones == 1 ? "Un millón" : ConvertirParteEntera(millones) + " millones") + (resto > 0 ? " " + ConvertirParteEntera(resto) : "");
            }

            return "Número fuera de rango";
        }

        

    }
}
