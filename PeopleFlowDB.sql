-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: dbpeopleflow
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `afp`
--

DROP TABLE IF EXISTS `afp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `afp` (
  `idAFP` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL,
  `porcentaje` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`idAFP`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `afp`
--

LOCK TABLES `afp` WRITE;
/*!40000 ALTER TABLE `afp` DISABLE KEYS */;
INSERT INTO `afp` VALUES (1,'AFP Capital',_binary '','2025-03-07 00:13:40',1.44),(2,'AFP Cuprum',_binary '','2025-03-07 00:13:40',1.44),(3,'AFP Habitat',_binary '','2025-03-07 00:13:40',1.27),(4,'AFP Modelo',_binary '','2025-03-07 00:13:40',0.58),(5,'AFP Planvital',_binary '','2025-03-07 00:13:40',1.16),(6,'AFP Provida',_binary '','2025-03-07 00:13:40',1.45),(7,'AFP Uno',_binary '','2025-03-07 00:13:40',0.49);
/*!40000 ALTER TABLE `afp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `anexocontrato`
--

DROP TABLE IF EXISTS `anexocontrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `anexocontrato` (
  `idAnexoContrato` int NOT NULL AUTO_INCREMENT,
  `IdContrato` int DEFAULT NULL,
  `Titulo` varchar(45) DEFAULT NULL,
  `Archivo` text,
  `FechaReg` datetime DEFAULT NULL,
  `Usuario` int DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  `ArchivoB` longblob,
  PRIMARY KEY (`idAnexoContrato`),
  KEY `FK_Anexo_Contrato_idx` (`IdContrato`),
  KEY `FK_Anexo_Empresa_idx` (`IdEmpresa`),
  CONSTRAINT `FK_Anexo_Contrato` FOREIGN KEY (`IdContrato`) REFERENCES `contratos` (`IdContrato`),
  CONSTRAINT `FK_Anexo_Empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `anexocontrato`
--

LOCK TABLES `anexocontrato` WRITE;
/*!40000 ALTER TABLE `anexocontrato` DISABLE KEYS */;
INSERT INTO `anexocontrato` VALUES (8,6,'Anexo 1','C:\\Users\\Kyousukee\\Documents\\Contrato.pdf','2025-04-18 01:04:19',2,3,_binary '%PDF-1.7\n%\‚\„\œ\”\n5 0 obj\n<</Filter/FlateDecode/Length 2354>>stream\nxúïY\Õn\€Hæ˚)\Z¡ì\02\Õ_˝\‰4[ìuê\ÿ[	_ZdKnÅd+MRâÛ ˚{ﬁ∑Òq9¸˚U7[¢[ÙƒÄMâ]]\’U_}U\’˘|\€\Ï\‡\Ë˜Ä!õ-\¬ ÒÜC6ö$\ﬁ(f≥\Ï\‡\Â\…\≈˘\ÏÚxv¡Nß\Ï√ª\„_∞\ﬂ\œ\ﬁ^ºö≠¶≥É?>[˘∞ïè ;úx+;-Y\ŒY*õåg,Ïíó)_6|¿8´\Ó\Ê<Slå\ÔsVàä\ﬁ\\SÙ˙a2`¢¨µ†¶\≈Zãä≥Së\ÀTÚäΩkJlr\È}Ùf;ˇ/YÛí\Ì≥)zÅµ)òx\·0Ò¢a|80-hg(\‚gk•Y¶\ \ÎóÒ\ÎW\Ï-\ﬂH°9ªî¸Å∂è3®b$ü\ƒN^î¨jX\ siè\ÿoIzëµ\‰8+d)´Z\√\Z.)\Ê™b©*aCÅc\ÊR±5á¢™ÒB,Dj˛ñ\Ï<^\ËTdp\€\’\—˘\0RZ\≈Dé5˙æî©\Í7${â5deO\Íis\“_óóπó™\¬è#>º¨{Å8âbù2˜ª%W1\Á+U	ˆ^.¨˘$Ùí\Ã>\Œ7\\ão+LA\Ï`¥ˇÉ+y*ïÎó§\n\Z\¬\–É\…d< ∞\–kU∂!8πëπ p\‡\≈Z´Ö®\‰=ô\Ÿ0µÄSv8î¥Vyn˝˛ú†˘æÉ4ÇA∞M\ÂF\Ê\ÏJ\Âµ\–j∞çΩ¢\0\…2SèEÖ≠\‡(oc=ÙÎç™ütıQ\Œ{\Õ\ZéG\’\0—úØ\Ë@\∆K/π\·ßç(\…{[Ö\0IA\n5$jìkVTy?*\n:äÜÅ\ÌáÀ≥˜\”ÀãüV;≥&£\Ójˆ6Õè\ﬁqˆÉ}dNç\0\Ê\‹25\œÂíÉ\ƒJ§M\Õ5\Ÿ\€ZfòC\‰´y¸¿´\Z.≠\ÿ\Á¶?r\√x\‰PïπÄõ°N»∏\«\ﬁ!ù*°7Ñzb\ƒ\–}Wöºñ5}≠Fk)\0.\")U¬Ñn&∞Zîdy\⁄ù©\néóeøYQ‰Äæz’êt6p\›;\Âµ!ìÆº\‰6\ƒO•º!Æö™ñ¿5\ÿk@\¬%Ø\ÕsÒçõ›∫\Á0\¬@øe¡ñΩç •E*\À\⁄\0.\«&¥\Ô\r/mäèUb`ò&T\nørY\»\ZiyoëTeÄÜXõS\Œ\‰\‡©BÊúûnüL\À\‚MŸàçb?\Zâ}2R|;è≤*`ír,≠⁄ädL^(]¿µx\rˇ\‚yõ¡ÿü\Î˙;B\—œ§\…dK\ÈA¯?∑ì˚L.ïyúıßW2:ê^M\ﬂ|<?›ì^cR\’`á(†]R€•3˛é>\«1~$¯RπëÛ~0u\ﬂrˆ	¸è\'√ö˛\‰µ\Ô\„ª`åø˝áOBá\‰•9Öá^Hx´¯56ªEÇ†^Q\‚)⁄õ\—bZí.\'¬¢\«Hx`\rVK†\ﬂƒ∞]M≈∞ﬂûh\ÏMc\œvkÁäîkêkáë¯\ﬁ\ÿë\ÿ˝f\”ÀìΩ\‘gc≥@l¶\›~Hzò-\‡§Ù\√L˝\ŸBÀôî`\rı\"\œ˙QO&^d\Ì(DY5<7˙yLs\Î{Ú˜∂$¿\Ô\‘\Ì<Æ\⁄|É\ÏY•r.±Ülxnâ\Èë\Ô˚ÄÜà\Èu+\'^bMwê\'\Ã0¯∂•…≤ÜµÙóG¯ˇó¡÷ÅTˇw\ÎA()7\r]{Ç\ÿo\’(F\÷*\n\«Z\ÀµΩ\¬\…)qæ\⁄7wsi≤®\ÌXw\ŒkuﬂÅ¯>Sr\‰∑¿\ÎíS@^Å\„æ+îÜjLÕå…ì˛:\'#áf\"*një“∂\ﬂ1¨’ö∂\rXer™˚\Ì|t_∂]ÏÑ£3âØüÅ£8vx6-®‹®#h+´Ö\–t\‰ˆ\ÈZ+PÒ^öãÉ±C\‰\…\«\„\ÀŸûL\n∫ã˚\“H’ä˙)\‘«üpkÚ\ E©bsQ\n\”VOôå|¥ˆ,\Zè=\ﬂjG∑òjπ&˜=%£…Äã:Bü(5û:]\Ï{Xå)ãV˛¶Ä\Í7\0º)\„ÿßc1Ò\‰M\“Q\÷\ÌWG@F”â\·DdKÿßf\'¯ò&ü\—\œ\Âõür\Ê§ºh\Ãb?Ù∆¨h?EQ\‚MX~pıÑD\“YüÙ¨Ní±7å∂\Ì\«>\rf}Y\r^4rüüñàΩa∏ìJíIø\‚\Ó\”q∑J\⁄\œ=J∂R§§WÑE8q\‘9I˚πOâì2J˙D\‡œ°vOb?˜)qRF\…Cë9 BuZX˝ÒÒ\Ï|`∂é∫\Îˇ\Ó,!æöKC˛`â¥ÅH™Oì%⁄†&•D∞s&É^\"QP\«I;J†˚ï\Zí\⁄tR\ƒU\√V H\Ï]†œ°¶\⁄z»ñé)-#{õaF>-\⁄Ö\”Æw£nâõ!®øDÑ\„°cùZë1USQ´D|Gg-©nÿöu)ñπÒábgpä∂ıÙB£[∞\ %Xí¸w%ñç6ùÚıK\Zvæ¢iî\⁄6h˝\ÊåB/lÀÖ=\Áı´Å1Ñ‹úâ\‘4(Ú*\⁄ˆ˝Ãî∂\“\Z\rˇ\’b©\ÕL6∑\◊3ªëï™˛ˆ¥\"EÖ\Ô7ÿèìs \Í˙\“Ù19\rÆ˜’Æ0\nØ¶ˇ\⁄\€\—\ƒéª\Àmı˙\È,√†ÜB|ÉnÜ∫.\Êè˝\·!]|¡+\’}N\Ë…∞`≠\ ?1_¡\‰˙O]\»RµM9\Õ\È1A-mëK≥ôX ™E\›F.…™}\'&ë\√\◊\’Ù\√\Ï\Ï˝û≤S\‹¿ŸØ(å+q\‘dÅ\";iåò/\·ü{fzT\€ˇ0˛∂äåÉˆY;9¯]úÃé?\Ì\Î1à_:\Îü\n≤ê\‘{¡\Ô\—,vX2h.\Ì\ÌJ\Á<7|p\”H:ó\Ì<Y=£\rí»Åîß\–\‹¡&%j&\”\’róÅˇ¿∫≤≤~i±\»\≈j\◊˘µQ6Û6|\Î.É\Ï|µunø]\—ƒ°\Œ\ÿ^\’î§\Ë!\€y9oñ\÷N\«b]Ûç3cπ¢ìÕún™Ç.\—ƒúZhM¯\ƒ\Àg\ÿ&\◊6m\r≤W_ƒºı«©DD\⁄;â\Ì\\é˚ÚÂãó\Ÿwtªìª±4ø~µ73|\ﬂ˝¸\‚\”Ùºkªı¿\⁄\‚¡\⁄\Ãy\Áz7Zn®èú˝ì∂Ïæê+ﬁΩ,o\€{›á\¬\—B\ﬂ\›\ÀÛ`ê1ÖîJ∂{ãRPy\Ó.á™ÀåÆÃÖ\¬\ﬁKCﬂÅ˘tz\⁄x˝S˚®óf\¬9çX\”ˇ;ò\∆BãÉ\≈#>Ùi¡nSsE`SN£»ë\·t∑GnàxÉ°@~#»ô;Ù\ÌJ{I!æ\‚•1q-πΩ¥\€ ∏Vø\„ºˇR\–E\nendstream\nendobj\n4 0 obj\n<</Contents 5 0 R/MediaBox[0 0 595 842]/Parent 2 0 R/Resources<</Font<</F1 6 0 R/F2 7 0 R>>>>/TrimBox[0 0 595 842]/Type/Page>>\nendobj\n9 0 obj\n<</Filter/FlateDecode/Length 1399>>stream\nxú≠Wªr7\Ì˘W\“sü$UÖ∂\Èôd¸H&ï\Zp§†Y4∞À±ıûÙ˘\◊˘ï.\\d‘• π\ÿ]íñE.\'c6w/.\Œ=˜\\]\ÔŸ¨˜Ùe¿Çê\ÕΩ(e\√Qƒá1õ\ÂΩ3˘~m•,óì´u!En,?ü\›Ù¶≥ﬁØΩwﬂÆMÜ|\\Ø˝\ÎXXÚ\‡Ñ∞A £Æ∞ñ¶)\«>íü˛\È\»x\\\Á|˘\”\Â\Î	õ]NûM~ûºx{yu6π:\ÔX\ƒ<üÇ=ç¯®éº¸}∆æ˛pò|R⁄§Yôæ˛\Â’îH\ÈZx!M\Ë˜gbJb$\Ì\÷\\F|\–èá<<!l¯@X∏\'<≠\√ﬁºùM.ex:‹èf#£S#i˚(h©π:Æ\Œ\Ÿ+˘ÅΩ˘<\ná}t?{mriµ∫ô∫\◊Ù†ÏÖ≤2kælf\≈\\\‹\Œ~ìL,≠\\\ﬁ3©^\Ëj%≠(X\Ë√îŒî3Ñ\Â8¢`\‘VamøZ\ÿÚKVÜÉæ\‹\Ë“äíﬁ∂ò`û*]\ÌÉ]ãBÃ≠`O4û\Z-\nïã¸Iü^9µ¨î‘•\ÏF5à€¢/¨pÚÇ!CnV*SÖ2\Ï\À˜(\nk•2+\ÌΩVôG)Vs\·\0«ñ\“ı±7!(´çíV\Í\'ıGc>àˆ\√ç—£IS\œıú¥ºÖaø)>{e˜I∫1Vã\\0cs•ÖUd¸¨l\r®Ö\ 0\ÿ\⁄Xä\ﬂ\ $I\Œ&ù¸E√îß5.*ë∞æÜa\ \ÈXÉ0\Ó\ÔÉ\ÿm\Õ4X|üIH\Œ[	êU\néKh\„⁄†ê^Ö\n∏“™y\ÂO\Â$ê\ÊˆÆX\ZÚQ\rL.P.l@\Í\Õáì+°°)QHùÉ\√sfn=c®•$HkkV2W\∆5\·Ötî†kág∏Äk∏\›pbTªÜSßÉRNı¡\0j˜h≠¥©O\€rıê*‘Ωaj∑»µ\«\Ï\∆yk\ﬁa\Í3≠∞U	V§u$w¥ª+AÀóï*•\◊\»\Í\Œ>\ﬂÚ\‚;tm˚\€E\—mA\·g\›\”L%¨Jîj\„5¥Ks\·/´§Öv=\Œ÷à\0kY\Èºvómó$qm.˜πZö}w\Îw\”4∂_=\⁄/µ©≤èà®ÄqîU\Ów®µN˜´´3qu\ﬁ\'åÑΩ©©ï8ﬁ≠∞Æ!ñ\ƒ\Ê|-\ﬂU≤œ∫Eé£V\„\Ëìm)r.t\ÊE\r°Wê\–\n\¬F6Ç£›ÇL)É¥v&XêêΩ™ö\’\‚¡	\»\◊4.,,N@6\Z¥rW+úÆ$19ò∫(PCf)\ÿÁÇ≥\È\r]BQ\Œi√ç\ÿ\ﬂı)$	zZ¶\Ó<Iæ˛ıa∫\·–µ©1Éá\Á\ﬁŒäÜÅÉìöÚ\ƒ[~û\Ã\≈Ñ\Á\Ê\ÿ\n∫\"\’+fjMEˇ\€Ãæv?ˆá/[ÑQaº\'Òë|›£\Í|óUyÅUı\Áá\‡ÿ¢4j´Ò¸õ	v\ﬂqío§]¢(?^õr%T¡3≥:ñ1\Zû\“\”8“ÆßcÙÙî‹§$\"¸4m&=ïX-e\”Söµ+¸°˜§xôknò±ú…òΩ˘õ˝ˇé\„∂(πú£¯\Ëgòû˜<˙u\‰\’\0\”\ÿJ\„†&BÙ˛¯´Ñ\«ˆ\'m\Ì˛dØ\ƒ˛®.vdê¡\‚\÷Ù\ŸB\·0èŒÄJ3Ò\ﬁ9Qlå\ÔJ\Á[Û\◊œÆ%5n#\'x\»(l•±\∆˘qçr>\ËX\nMï_J2På√Öt˛ûE^Ú9#\Ì¿VJ\›4~®¥+\·~tì~J»º\ \Í#∫\n\ÈïÒ◊ÉNL\È®W\›_\ÿó0£M¶öù>CG˝zp\÷\¬¿T,®õ∑ú>F\r-vxb°˘x\Ó\Ìe∑\⁄ˆ\’$\·î€´óìvÉQÄ\r+\‹46Ú8\÷\ \“ah\nPÅIaµçë\‹˝\‘\ﬁ\”¿ˆ \n\√x°4\·A\ÿ	.˚¯yø¥É˝ÉÉ§\nendstream\nendobj\n8 0 obj\n<</Contents 9 0 R/MediaBox[0 0 595 842]/Parent 2 0 R/Resources<</Font<</F1 7 0 R/F2 10 0 R>>>>/TrimBox[0 0 595 842]/Type/Page>>\nendobj\n12 0 obj\n<</Filter/FlateDecode/Length 756>>stream\nxúçïAn\€0E˜>\≈, P#…í\Ì.ã¶´†@/≥°≈±BC\"R2í^£\Ì=z•.ª\»*\Ë\'%9j\€\›â\√æ˘ˇs¸0{∑ûΩ˘Sú\–z;KsZ,\”h1ßµú]|ß\◊\ZGÖ—≠˛7˜R≤V-k\Í¥ \À\⁄\ÏE°^tD∑Çóùñ”è	(\÷nkl-ec7íL≤≥\·\‘\Âz7ª ˇÛf=˚4{¯ó*_E´ûJi\…[•ï—±Ç\Â\"\ ˇ®9\Ÿ:À£x34ñ]€≥É–±›´Bav©úGW∫Û\0\\∑\Ïª\‘\Ïÿë°˙ß£†\n5lüç>tJ<úπüütûDiè\„I∫ZYta?ΩJw\–¿\’ âÛhµò∂;yk≤å≤É\Îﬁµ©\Ì˛~8^ä\ﬁÙ\—5?`zMÚYÑ˘·πªÇ`P°UB`U£º.ïOE\›i˛_\«\„˘òCÄ\ÏYá>5¢4\‘K[∂J@\Â\'`x\Ì%[.\ÓZPH\ﬁ˜»∏º±%ÅYT∫∫1ΩµPê>s©\ÏOûá∫æ#U+á<#çq*tv\ ÛM<\¬«∏\Ì^x\Ìp(^¨5•ÄJû\\≠iqbê…ÑÒ¨™\Ÿ\"§\ÕY¶iÚÀèC%(ü˜∂MGú§>ì⁄ìW,\“1D·â¥lk•˚\‡`\ŒFÑ{\'\„\„!U‚ã°≠\⁄§B\È~\ÊGÖ\«EÖ\Ë\ﬂuÆU[U¯b≥©T)º=0ßb8k\Èº!y∂\Zsã`\ÎcDEZ§\¬ôkSuà\Á∞\ÀBñåé[\‰&®\÷˛Ús»©Rã>πì©é\Íô%ã(ôOqNRœ≥1\€w\Ÿ\›%\›Ú}¸ë\ƒQö,˙pà\“r/l˚\\tX£+⁄®1: \ﬂT\\[˙zV™_Øaf\·7ÆèeáCf\‡{ú\◊3ç«Ägqv\Âk_ÌêºaºÄ¡D±˚\ÊNµ\ góã÷æ ÙaÒA\÷˜\nr\ÿ≠≠ÿàù˘k≥x\—˚\\ùgãócX%Ã¥fÙwX≤a¡∑Àß≈∫\≈\◊QG∏6˝ âæöˇ+©\'(\nendstream\nendobj\n11 0 obj\n<</Contents 12 0 R/MediaBox[0 0 595 842]/Parent 2 0 R/Resources<</Font<</F1 7 0 R>>>>/TrimBox[0 0 595 842]/Type/Page>>\nendobj\n1 0 obj\n<</Pages 2 0 R/Type/Catalog>>\nendobj\n3 0 obj\n<</CreationDate(D:20250325221141-03\'00\')/ModDate(D:20250325221141-03\'00\')/Producer(iTextÆ pdfHTML 6.1.0 \\(AGPL version\\) ©2000-2025 Apryse Group NV)>>\nendobj\n6 0 obj\n<</BaseFont/Times-Bold/Encoding/WinAnsiEncoding/Subtype/Type1/Type/Font>>\nendobj\n7 0 obj\n<</BaseFont/Times-Roman/Encoding/WinAnsiEncoding/Subtype/Type1/Type/Font>>\nendobj\n10 0 obj\n<</BaseFont/Times-Italic/Encoding/WinAnsiEncoding/Subtype/Type1/Type/Font>>\nendobj\n2 0 obj\n<</Count 3/Kids[4 0 R 8 0 R 11 0 R]/Type/Pages>>\nendobj\nxref\n0 13\n0000000000 65535 f \n0000005148 00000 n \n0000005630 00000 n \n0000005193 00000 n \n0000002437 00000 n \n0000000015 00000 n \n0000005359 00000 n \n0000005448 00000 n \n0000004046 00000 n \n0000002579 00000 n \n0000005538 00000 n \n0000005013 00000 n \n0000004189 00000 n \ntrailer\n<</ID [<24bbb02778917d29eca425d9d9f7c509a9bf130d45fcc999fa9c67403a4e7c5b88e24ef054749f447f51d1ce1340e5396f497b129bb807e7788cdb5098cbec37><24bbb02778917d29eca425d9d9f7c509a9bf130d45fcc999fa9c67403a4e7c5b88e24ef054749f447f51d1ce1340e5396f497b129bb807e7788cdb5098cbec37>]/Info 3 0 R/Root 1 0 R/Size 13>>\n%iText-pdfHTML-6.1.0\nstartxref\n5694\n%%EOF\n');
/*!40000 ALTER TABLE `anexocontrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `archivosempresa`
--

DROP TABLE IF EXISTS `archivosempresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `archivosempresa` (
  `idArchivos` int NOT NULL AUTO_INCREMENT,
  `Titulo` varchar(45) DEFAULT NULL,
  `Archivo` text,
  `FechaReg` datetime DEFAULT NULL,
  `Usuario` int DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  `ArchivoB` longblob,
  PRIMARY KEY (`idArchivos`),
  KEY `FK_Archivos_Empresa_idx` (`IdEmpresa`),
  CONSTRAINT `FK_Archivos_Empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `archivosempresa`
--

LOCK TABLES `archivosempresa` WRITE;
/*!40000 ALTER TABLE `archivosempresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `archivosempresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bonificaciones`
--

DROP TABLE IF EXISTS `bonificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bonificaciones` (
  `IdBonificacion` int NOT NULL AUTO_INCREMENT,
  `IdEmpresa` int NOT NULL,
  `Descripcion` varchar(200) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Monto` decimal(18,2) NOT NULL,
  `FechaAplicacion` date DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `ParaEmpleado` bit(1) DEFAULT NULL,
  `IdTarea` int DEFAULT '0',
  `Imponible` bit(1) DEFAULT NULL,
  PRIMARY KEY (`IdBonificacion`),
  KEY `fk_bonificacion_empresa_idx` (`IdEmpresa`),
  CONSTRAINT `fk_bonificacion_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bonificaciones`
--

LOCK TABLES `bonificaciones` WRITE;
/*!40000 ALTER TABLE `bonificaciones` DISABLE KEYS */;
INSERT INTO `bonificaciones` VALUES (1,1,'Colacion',20000.00,'2025-03-07',_binary '',_binary '\0',0,_binary '\0'),(2,1,'Transporte',50000.00,'2025-03-07',_binary '',_binary '\0',0,_binary '\0'),(3,1,'Beneficio',10000.00,'2025-03-08',_binary '',_binary '\0',0,_binary '\0'),(4,3,'Gratificacion',25000.00,'2025-03-09',_binary '\0',_binary '\0',0,_binary ''),(6,3,'Bono Colacion 2',30000.00,'2025-03-09',_binary '',_binary '',0,_binary '\0'),(7,3,'Bono Gratificacion',30000.00,'2025-03-25',_binary '',_binary '\0',0,_binary '');
/*!40000 ALTER TABLE `bonificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bonificacionesempleados`
--

DROP TABLE IF EXISTS `bonificacionesempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bonificacionesempleados` (
  `idBonificacionesEmpleados` int NOT NULL AUTO_INCREMENT,
  `IdBonificacion` int DEFAULT NULL,
  `IdEmpleado` int DEFAULT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT b'1',
  `Fec_Crea` datetime DEFAULT NULL,
  PRIMARY KEY (`idBonificacionesEmpleados`),
  KEY `fk_Bemeplados_Beneficio_idx` (`IdBonificacion`),
  KEY `fk_bempleados_empleado_idx` (`IdEmpleado`),
  CONSTRAINT `fk_Bemeplados_Beneficio` FOREIGN KEY (`IdBonificacion`) REFERENCES `bonificaciones` (`IdBonificacion`),
  CONSTRAINT `fk_bempleados_empleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bonificacionesempleados`
--

LOCK TABLES `bonificacionesempleados` WRITE;
/*!40000 ALTER TABLE `bonificacionesempleados` DISABLE KEYS */;
INSERT INTO `bonificacionesempleados` VALUES (1,3,2,'admin1',_binary '','2025-03-08 12:08:52'),(2,6,4,'javiLuna',_binary '','2025-03-09 21:45:54'),(3,6,5,'javiLuna',_binary '','2025-03-09 21:46:02');
/*!40000 ALTER TABLE `bonificacionesempleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cargasempleados`
--

DROP TABLE IF EXISTS `cargasempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cargasempleados` (
  `idCargasEmpleados` int NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int DEFAULT NULL,
  `NCargasHijos` int DEFAULT NULL,
  `NCargasConguye` int DEFAULT NULL,
  `NCargasInvalidez` int DEFAULT NULL,
  PRIMARY KEY (`idCargasEmpleados`),
  CONSTRAINT `FK_cargas_Empleados` FOREIGN KEY (`idCargasEmpleados`) REFERENCES `empleados` (`IdEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cargasempleados`
--

LOCK TABLES `cargasempleados` WRITE;
/*!40000 ALTER TABLE `cargasempleados` DISABLE KEYS */;
INSERT INTO `cargasempleados` VALUES (1,5,2,1,1);
/*!40000 ALTER TABLE `cargasempleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contratos`
--

DROP TABLE IF EXISTS `contratos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contratos` (
  `IdContrato` int NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaFin` date DEFAULT NULL,
  `IdTipoContrato` int NOT NULL,
  `IdPlazo` int DEFAULT NULL,
  `NPlazo` int DEFAULT NULL,
  `Descripcion` text,
  `FechaCreacion` datetime DEFAULT CURRENT_TIMESTAMP,
  `Estado` bit(1) DEFAULT b'1',
  `IdTarea` int NOT NULL,
  `IdEmpresa` int DEFAULT NULL,
  PRIMARY KEY (`IdContrato`),
  KEY `fk_contratos_empleados` (`IdEmpleado`),
  KEY `fk_contratos_tipo` (`IdTipoContrato`),
  KEY `fk_contratos_tarea_idx` (`IdTarea`),
  KEY `fk_contrato_empresa_idx` (`IdEmpresa`),
  CONSTRAINT `fk_contrato_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`),
  CONSTRAINT `fk_contratos_empleados` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`),
  CONSTRAINT `fk_contratos_tarea` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`),
  CONSTRAINT `fk_contratos_tipo` FOREIGN KEY (`IdTipoContrato`) REFERENCES `tipocontratos` (`IdTipoContrato`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contratos`
--

LOCK TABLES `contratos` WRITE;
/*!40000 ALTER TABLE `contratos` DISABLE KEYS */;
INSERT INTO `contratos` VALUES (5,2,'2025-03-06','0001-01-01',2,4,3,'sdfsdfsdf','2025-03-06 14:08:23',_binary '',3,1),(6,4,'2020-03-08','2025-06-08',1,4,3,'Activo','2020-03-08 12:54:41',_binary '',5,3),(7,5,'2025-03-01','0001-01-01',2,0,0,'prueba','2025-03-23 22:35:59',_binary '',7,3);
/*!40000 ALTER TABLE `contratos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deducciones`
--

DROP TABLE IF EXISTS `deducciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deducciones` (
  `IdDeduccion` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(200) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Monto` decimal(18,2) NOT NULL,
  `FechaAplicacion` date DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  `Estado` bit(1) DEFAULT b'1',
  `ParaEmpleado` bit(1) DEFAULT b'1',
  PRIMARY KEY (`IdDeduccion`),
  KEY `FK_deducciones_Empresa_idx` (`IdEmpresa`),
  CONSTRAINT `FK_deducciones_Empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deducciones`
--

LOCK TABLES `deducciones` WRITE;
/*!40000 ALTER TABLE `deducciones` DISABLE KEYS */;
INSERT INTO `deducciones` VALUES (1,'Prestamo JOSE',200000.00,'2025-03-12',3,_binary '',_binary ''),(2,'Anticipo',50000.00,'2025-03-24',3,_binary '',_binary '');
/*!40000 ALTER TABLE `deducciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deduccionesempleados`
--

DROP TABLE IF EXISTS `deduccionesempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deduccionesempleados` (
  `idDeduccionesEmpleados` int NOT NULL AUTO_INCREMENT,
  `IdDeduccion` int NOT NULL,
  `IdEmpleado` int NOT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `Fec_Crea` datetime DEFAULT NULL,
  PRIMARY KEY (`idDeduccionesEmpleados`),
  KEY `fk_deduccionempleado_deduccion_idx` (`IdDeduccion`),
  KEY `fk_deduccionempleado_empleado_idx` (`IdEmpleado`),
  CONSTRAINT `fk_deduccionempleado_deduccion` FOREIGN KEY (`IdDeduccion`) REFERENCES `deducciones` (`IdDeduccion`),
  CONSTRAINT `fk_deduccionempleado_empleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deduccionesempleados`
--

LOCK TABLES `deduccionesempleados` WRITE;
/*!40000 ALTER TABLE `deduccionesempleados` DISABLE KEYS */;
INSERT INTO `deduccionesempleados` VALUES (2,1,4,'javiLuna',_binary '','2025-03-22 00:12:12'),(4,2,5,'javiLuna',_binary '','2025-03-25 20:44:27');
/*!40000 ALTER TABLE `deduccionesempleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documentosplanilla`
--

DROP TABLE IF EXISTS `documentosplanilla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `documentosplanilla` (
  `idplanilla` int NOT NULL AUTO_INCREMENT,
  `planilla` text,
  PRIMARY KEY (`idplanilla`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documentosplanilla`
--

LOCK TABLES `documentosplanilla` WRITE;
/*!40000 ALTER TABLE `documentosplanilla` DISABLE KEYS */;
INSERT INTO `documentosplanilla` VALUES (1,'\n<div style=\"font-family: monospace;\" >\n<p style=\"text-align: center;\"><strong>LIQUIDACION DE SUELDO</strong></p>\n<p><strong>REMUNERACIONES MES DE:&nbsp; &nbsp;[[PERIODO]]</strong></p>\n<p><strong>RAZON SOCIAL:&nbsp;&nbsp;&nbsp;[[RAZONSOCIAL]]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RUT EMPRESA:&nbsp; &nbsp;[[RUTEMPRESA]]</strong></p>\n<p>____________________________________________________________________________________________________</p>\n<table style=\"border-collapse: collapse; font-family: monospace; width: 700px;\">\n    <tr>\n        <th style=\"text-align: left;\">R.U.T. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;TRABAJADOR</th>\n        <th style=\"text-align: center;\">C.C.</th>\n    </tr>\n    <tr>\n        <td style=\"text-align: left;\">[[RUTTRABAJADOR]] &nbsp; [[NOMBRETRABAJADOR]]</td>\n        <td style=\"text-align: center;\">[[NCONTRATO]]</td>\n    </tr>\n</table>\n<p>____________________________________________________________________________________________________</p>\n<table style=\"border-collapse: collapse; font-family: monospace; width: 700px;\">\n    <tr>\n        <th style=\"text-align: left;\">A.F.P.</th>\n        <th colspan=\"2\"></th>\n        <th style=\"text-align: center;\">[[SALUD]]</th>\n        <th colspan=\"2\"></th>\n        <th style=\"text-align: right;\">[[VALORPESO]]</th>\n    </tr>\n    <tr>\n        <td style=\"text-align: left;\">[[AFPEMPLEADO]]</td>\n        <td colspan=\"5\"></td>\n        <td style=\"text-align: right;\"></td>\n    </tr>\n    <tr>\n        <td style=\"text-align: left;\">[[PORCENTAJEAFP]]</td>\n        <td colspan=\"5\"></td>\n        <td style=\"text-align: right;\">[[PORCENTAJEUFUTM]]</td>\n    </tr>\n</table>\n<p>____________________________________________________________________________________________________</p>\n<table style=\"border-collapse: collapse; font-family: monospace; width: 700px; text-align: center;\">\n    <tr>\n        <th>DIAS</th>\n        <th>HH EXTRAS</th>\n        <th>HH FALTADAS</th>\n        <th>CARGAS</th>\n        <th>IMPONIBLE</th>\n        <th>TRIBUTABLE</th>\n    </tr>\n    <tr>\n        <td>[[DIAST]]</td>\n        <td>[[HEXTRAS]]</td>\n        <td>[[HFALTAS]]</td>\n        <td>[[CARGAS]]</td>\n        <td>[[IMPONIBLE]]</td>\n        <td>[[TRIBUTABLE]]</td>\n    </tr>\n</table>\n<p>____________________________________________________________________________________________________</p>\n<p>[[HABERES]]</p>\n<p>____________________________________________________________________________________________________</p>\n<table style=\"border-collapse: collapse; font-family: monospace; width: 700px; text-align: left;\">\n    <tr style=\"border-bottom: 1px solid black;\">\n        <th style=\"width: 35%;text-align: left;\">TOTAL HABERES:</th>\n        <td style=\"width: 20%; text-align: right;\">[[TOTALHABERES]]&nbsp;</td>\n        <th style=\"width: 50%; text-align: left;\">TOTAL DESCUENTOS:</th>\n        <td style=\"width: 20%; text-align: right;\">[[TOTALDESCUENTOS]]</td>\n    </tr>\n    <tr>\n        <th style=\"text-align: left;\">FECHA:</th>\n        <td style=\" text-align: right;\">[[FECHA]]&nbsp;</td>\n        <th style=\"text-align: left;\">ALCANCE LIQUIDO:</th>\n        <td>[[ALCANCELIQUIDO]]</td>\n    </tr>\n</table>\n\n<p><strong><sub>SON:&nbsp;&nbsp;</sub></strong>[[VALORSTRING]].</p>\n<p>Recib&iacute; conforme el alcance l&iacute;quido de la presente liquidaci&oacute;n, no teniendo cargo o cobro alguno que hacer por otro concepto.</p>\n<p>FIRMA DEL EMPLEADOR&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FIRMA DEL TRABAJADOR</p>\n<p>&nbsp;</p>\n<p>___________________________ &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ___________________________</p>\n</div>\n'),(2,'\n<!DOCTYPE html>\n<html lang=\"es\">\n<head>\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Certificado de Vacaciones</title>\n    <style>\n        body {\n            font-family: Arial, sans-serif;\n            margin: 40px;\n            padding: 20px;\n            border: 1px solid #ccc;\n            max-width: 800px;\n            background-color: #f9f9f9;\n        }\n        h1 {\n            font-size: 22px;\n        }\n        .info {\n            margin-bottom: 20px;\n        }\n        .highlight {\n            font-weight: bold;\n        }\n        .box {\n            background-color: #dcebf9;\n            padding: 10px;\n            margin-top: 10px;\n        }\n        .signature {\n            margin-top: 40px;\n        }\n    </style>\n</head>\n<body>\n    <h1>Certificado de Vacaciones</h1>\n    <p><strong>Fecha de Emisi√≥n:</strong> [[FECHAACTUAL]]</p>\n    \n    <div class=\"info\">\n        <p><strong>[[NOMBRETRABAJADOR]]</strong></p>\n        <p>Rut: [[RUTTRABAJADOR]]</p>\n        <p>C√≥digo Interno: [[IDVACACION]]</p>\n        <p><strong>Fecha de Ingreso:</strong> [[FECHAINGRESO]]</p>\n        <p>Sucursal: [[DIRECCIONEMPLEADOR]]</p>\n    </div>\n    \n    <div class=\"box\">\n        <p><strong>INFORMACI√ìN EMPRESA</strong></p>\n        <p><strong>Raz√≥n Social:</strong> [[NOMBREEMPLEADOR]]</p>\n        <p><strong>Rut:</strong> [[RUTEMPLEDOR]]</p>\n    </div>\n    \n    <p>En cumplimiento a las disposiciones legales vigentes se deja constancia que a contar de las fechas que se indican el (la) trabajador(a): <strong>[[NOMBRETRABAJADOR]]</strong>, RUT <strong>[[RUTTRABAJADOR]]</strong> que se desempe√±a como <strong>[[CARGO]]</strong>, har√° uso de <strong>[[CANTDIAS]] d√≠as</strong> h√°biles de feriado anual con remuneraci√≥n √≠ntegra.</p>\n    \n    <p>Esto se har√° efectivo entre los d√≠as <strong>[[FECHAINICIO]]</strong> hasta el <strong>[[FECHAFIN]]</strong>, ambas fechas inclusive, retornando a trabajar el <strong>[[FECHARETORNO]]</strong>.</p>\n    \n    <p><em>* Recuerda que mientras est√°s de vacaciones, sigues acumulando d√≠as.</em></p>\n    \n    <div class=\"signature\">\n        <p><strong>FIRMA EMPLEADOR</strong></p>\n        <p>------------------------------</p>\n        <p>[[RUTEMPLEDOR]]</p>\n        <p>------------------------------</p>\n    </div>\n    \n    <div class=\"signature\">\n        <p><strong>FIRMA TRABAJADOR</strong></p>\n        <p>[[RUTTRABAJADOR]]</p>\n    </div>\n</body>\n</html>\n\n'),(3,'\n<h2 style=\"text-align: center;\"><strong>Finiquito</strong></h2>\n<p><strong>&nbsp;</strong></p>\n<p>En&nbsp; [[CIUDAD]],[[FECHA]], entre [[RAZON_SOCIAL]] RUT: [[RUT_EMPLEADOR]] , con domicilio en calle [[DIRECCION_EMPLEADOR]], en adelante &ldquo;el empleador&rdquo;, por una parte, y don(&ntilde;a) [[NOMBRE_TRABAJADOR]] RUT: [[RUT_TRABAJADOR]], con domicilio en [[DIRECCION_TRABAJADOR]],de nacionalidad [[NACIONALIDAD]], nacido(a) [[FECHA_NACIMIENTO]], en adelante &ldquo;el trabajador&rdquo;, por otra parte, se conviene el siguiente finiquito:</p>\n<p><strong>PRIMERO</strong>.- Don (&ntilde;a) [[NOMBRE_TRABAJADOR]] &nbsp;declara haber prestado servicios a [[RAZON_SOCIAL]] &nbsp;en calidad de [[CARGO]] desde el [[FINICIOCONTRATO]],hasta el [[FECHA_FIN]],fecha esta &uacute;ltima de terminaci&oacute;n de sus servicios, por la causa que se indica a continuaci&oacute;n: [[CAUSA_FINIQUITO]],seg&uacute;n lo dispuesto en el art&iacute;culo N&deg;[[ARTICULO]] del C&oacute;digo del Trabajo.</p>\n<p>&nbsp;<strong>SEGUNDO</strong>.- Don(&ntilde;a) [[NOMBRE_TRABAJADOR]] &nbsp;declara recibir en este acto, a su entera satisfacci&oacute;n de parte de [[RAZON_SOCIAL]] las sumas que a continuaci&oacute;n se indican, por los siguientes conceptos:</p>\n<p>&nbsp;[[TABLADETALLEINDEMNIZACION]]</p>\n<p><strong>TERCER.-</strong>: Don(&ntilde;a) [[NOMBRE_TRABAJADOR]] &nbsp;deja constancia que durante todo el tiempo que le prest&oacute; servicios a [[RAZON_SOCIAL]] , recibi&oacute; de &eacute;ste(a), correcta y oportunamente el total de las remuneraciones convenidas de acuerdo con su contrato de trabajo, clase de trabajo ejecutado, reajustes legales, pago de asignaciones familiares autorizadas por la respectiva Instituci&oacute;n Previsional, feriados legales, en conformidad a la ley, y que nada se le adeuda por los conceptos antes indicados ni por ning&uacute;n otro, sea de origen legal o contractual derivado de la prestaci&oacute;n de sus servicios, y motivo por el cual no teniendo reclamo ni cargo alguno que formular en contra del empleador, le otorga el m&aacute;s amplio y total finiquito, declaraci&oacute;n que formula libre y espont&aacute;neamente, en perfecto y cabal conocimiento de todos y cada uno de sus derechos. Para constancia firman las partes el presente finiquito en dos ejemplares, quedando uno de ellos en poder del empleador y el otro en poder del trabajador.</p>\n<p>&nbsp;</p>\n<p>&nbsp;</p>\n<p>&nbsp;</p>\n<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;-----------------------------------&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ----------------------------------- &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>\n<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Nombre RUT y Firma Empleador&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Nombre RUT y Firma Trabajador</p>\n');
/*!40000 ALTER TABLE `documentosplanilla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `IdEmpleado` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Apellido` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Rut` varchar(15) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `FechaNacimiento` date NOT NULL,
  `Telefono` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Correo` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Direccion` varchar(200) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `FechaIngreso` date NOT NULL,
  `Estado` bit(1) DEFAULT b'1',
  `IdRol` int NOT NULL,
  `IdEmpresa` int NOT NULL,
  `Nacionalidad` varchar(45) DEFAULT NULL,
  `Profesion` varchar(45) DEFAULT NULL,
  `IdEstadoCivil` int DEFAULT NULL,
  `Banco` varchar(45) DEFAULT NULL,
  `TipoCuenta` varchar(45) DEFAULT NULL,
  `NumeroCuenta` varchar(45) DEFAULT NULL,
  `IdSalud` int DEFAULT NULL,
  `IdAFP` int DEFAULT NULL,
  PRIMARY KEY (`IdEmpleado`),
  UNIQUE KEY `Rut` (`Rut`),
  KEY `fk_empleados_roles_idx` (`IdRol`),
  KEY `fk_empleados_empresas_idx` (`IdEmpresa`),
  KEY `Fk_empleados_escivil_idx` (`IdEstadoCivil`),
  KEY `fk_empleado_salud_idx` (`IdSalud`),
  KEY `fk_empleados_afp_idx` (`IdAFP`),
  CONSTRAINT `fk_empleado_salud` FOREIGN KEY (`IdSalud`) REFERENCES `regimensalud` (`idRegimenSalud`),
  CONSTRAINT `fk_empleados_afp` FOREIGN KEY (`IdAFP`) REFERENCES `afp` (`idAFP`),
  CONSTRAINT `fk_empleados_empresas` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`),
  CONSTRAINT `Fk_empleados_escivil` FOREIGN KEY (`IdEstadoCivil`) REFERENCES `estado_civil` (`idEstado_Civil`),
  CONSTRAINT `fk_empleados_roles` FOREIGN KEY (`IdRol`) REFERENCES `roles` (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'Jose Miguel','Vergara Alvarez','19850956-6','1998-02-22','932507495','932507495','Vaticano n37','2025-03-05',_binary '',1,1,'Chilena','Otros',1,NULL,NULL,NULL,3,1),(2,'Javiera','Rivera','19265364-9','1996-09-03','922003994','javiera.17.rivera@gmail.com','Las Mercedez SN','2025-03-05',_binary '',2,1,'Chilena','Otros',1,NULL,NULL,NULL,3,1),(4,'Jose Miguel','Vergara Alvarez','11111111-1','1998-02-22','123456789','jose.vergara@hotmail.com','Lindo','2025-03-08',_binary '',3,3,'Chilena','Desarrollador',1,'Estado','Vista','11233344554',3,5),(5,'Luis Alfonso','Vergara','22222222-2','2025-03-09','222222222','luis.alfons@gmail.com','.','2025-03-09',_binary '',3,3,'Chilena','Otro',2,'Estado','RUT','22222222',3,5);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresas`
--

DROP TABLE IF EXISTS `empresas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresas` (
  `IdEmpresa` int NOT NULL AUTO_INCREMENT,
  `RUT` varchar(20) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT 'Activo',
  `FechaCreacion` datetime DEFAULT CURRENT_TIMESTAMP,
  `Direccion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdEmpresa`),
  UNIQUE KEY `RUT` (`RUT`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresas`
--

LOCK TABLES `empresas` WRITE;
/*!40000 ALTER TABLE `empresas` DISABLE KEYS */;
INSERT INTO `empresas` VALUES (1,'76.123.456-7','VAPlastic','Inactivo','2025-03-03 23:28:41','El Vaticano Requinoa, Rancagua.'),(2,'78.987.654-3','Innovatech Ltda.','Inactivo','2025-03-03 23:28:41','El Vaticano Requinoa, Rancagua.'),(3,'19.265.364-9','Delicias Luna','Activo','2025-03-03 23:28:41','Las Mercedes S/N');
/*!40000 ALTER TABLE `empresas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_civil`
--

DROP TABLE IF EXISTS `estado_civil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_civil` (
  `idEstado_Civil` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `FechaCreacion` datetime DEFAULT NULL,
  PRIMARY KEY (`idEstado_Civil`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_civil`
--

LOCK TABLES `estado_civil` WRITE;
/*!40000 ALTER TABLE `estado_civil` DISABLE KEYS */;
INSERT INTO `estado_civil` VALUES (1,'Soltero',_binary '','2025-03-06 23:21:24'),(2,'Casado',_binary '','2025-03-06 23:21:24'),(3,'Viudo',_binary '','2025-03-06 23:21:24'),(4,'Otro',_binary '','2025-03-06 23:21:24');
/*!40000 ALTER TABLE `estado_civil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estadostarea`
--

DROP TABLE IF EXISTS `estadostarea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estadostarea` (
  `IdEstadoTarea` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `Estado` bit(1) DEFAULT b'1',
  PRIMARY KEY (`IdEstadoTarea`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estadostarea`
--

LOCK TABLES `estadostarea` WRITE;
/*!40000 ALTER TABLE `estadostarea` DISABLE KEYS */;
INSERT INTO `estadostarea` VALUES (1,'Pendiente','2025-03-03 23:23:17',_binary ''),(2,'En Proceso','2025-03-03 23:23:17',_binary ''),(3,'Completada','2025-03-03 23:23:17',_binary ''),(4,'En Pausa','2025-03-03 23:23:17',_binary '');
/*!40000 ALTER TABLE `estadostarea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finiquitodetalle`
--

DROP TABLE IF EXISTS `finiquitodetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `finiquitodetalle` (
  `idFiniquitoDetalle` int NOT NULL AUTO_INCREMENT,
  `IdFiniquito` int DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Monto` decimal(18,2) DEFAULT NULL,
  `Fecha_Creacion` datetime DEFAULT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idFiniquitoDetalle`),
  KEY `FK_DetalleFiniquito_Finiquito|_idx` (`IdFiniquito`),
  CONSTRAINT `FK_DetalleFiniquito_Finiquito|` FOREIGN KEY (`IdFiniquito`) REFERENCES `finiquitos` (`idFiniquitos`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finiquitodetalle`
--

LOCK TABLES `finiquitodetalle` WRITE;
/*!40000 ALTER TABLE `finiquitodetalle` DISABLE KEYS */;
INSERT INTO `finiquitodetalle` VALUES (3,3,'Indemnizaci√≥n A√±os',213.00,'2025-04-17 10:28:46','2');
/*!40000 ALTER TABLE `finiquitodetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finiquitos`
--

DROP TABLE IF EXISTS `finiquitos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `finiquitos` (
  `idFiniquitos` int NOT NULL AUTO_INCREMENT,
  `IdContrato` int NOT NULL,
  `FechaFiniquito` date DEFAULT NULL,
  `IdTipoFiniquito` int DEFAULT NULL,
  `Observacion` varchar(250) DEFAULT NULL,
  `Fecha_Creacion` datetime DEFAULT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  PRIMARY KEY (`idFiniquitos`),
  KEY `FK_Finiquito_Contrato_idx` (`IdContrato`),
  KEY `FK_Finiquito_Tipo_idx` (`IdTipoFiniquito`),
  KEY `FK_Finiquito_Empresa_idx` (`IdEmpresa`),
  CONSTRAINT `FK_Finiquito_Contrato` FOREIGN KEY (`IdContrato`) REFERENCES `contratos` (`IdContrato`),
  CONSTRAINT `FK_Finiquito_Empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`),
  CONSTRAINT `FK_Finiquito_Tipo` FOREIGN KEY (`IdTipoFiniquito`) REFERENCES `tipofiniquito` (`idTipoFiniquito`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finiquitos`
--

LOCK TABLES `finiquitos` WRITE;
/*!40000 ALTER TABLE `finiquitos` DISABLE KEYS */;
INSERT INTO `finiquitos` VALUES (3,6,'2025-04-18',9,'sdsadergdfgdfg','2025-04-17 00:34:28','2',3,_binary '');
/*!40000 ALTER TABLE `finiquitos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finiquitostipodetalle`
--

DROP TABLE IF EXISTS `finiquitostipodetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `finiquitostipodetalle` (
  `idFiniquitosTipoDetalle` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `FechaCrea` datetime DEFAULT NULL,
  PRIMARY KEY (`idFiniquitosTipoDetalle`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finiquitostipodetalle`
--

LOCK TABLES `finiquitostipodetalle` WRITE;
/*!40000 ALTER TABLE `finiquitostipodetalle` DISABLE KEYS */;
INSERT INTO `finiquitostipodetalle` VALUES (1,'Indemnizaci√≥n A√±os',_binary '','2025-04-07 21:56:10'),(2,'Indemnizaci√≥n por T√©rmino de Contrato',_binary '','2025-04-07 21:56:10'),(3,'Vacaciones Proporcionales',_binary '','2025-04-07 21:56:10'),(4,'Sueldo D√≠as Trabajados no Pagados',_binary '','2025-04-07 21:56:10'),(5,'Pagos Pendientes por Tareas No Abonadas',_binary '','2025-04-07 21:56:10'),(6,'Otros',_binary '','2025-04-07 21:56:10'),(7,'Mes Aviso',_binary '','2025-04-20 21:58:41');
/*!40000 ALTER TABLE `finiquitostipodetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historialacciones`
--

DROP TABLE IF EXISTS `historialacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historialacciones` (
  `IdHistorial` int NOT NULL AUTO_INCREMENT,
  `IdUsuario` int NOT NULL,
  `Accion` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Tabla` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `IdRegistro` int DEFAULT NULL,
  PRIMARY KEY (`IdHistorial`),
  KEY `fk_historialacciones_empleados` (`IdUsuario`),
  CONSTRAINT `fk_historialacciones_empleados` FOREIGN KEY (`IdUsuario`) REFERENCES `usuarios` (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historialacciones`
--

LOCK TABLES `historialacciones` WRITE;
/*!40000 ALTER TABLE `historialacciones` DISABLE KEYS */;
INSERT INTO `historialacciones` VALUES (1,2,'update','jornadas','2025-03-31 00:31:45',1),(2,2,'insert','jornadas','2025-03-31 00:33:16',5),(3,2,'update','tareas','2025-03-31 01:21:45',5),(4,2,'update','finiquitos','2025-04-17 00:25:17',7),(5,2,'insert','finiquitos','2025-04-17 00:28:05',1),(6,2,'insert','finiquitos','2025-04-17 00:32:08',2),(7,2,'insert','finiquitodetalle','2025-04-17 00:32:15',1),(8,2,'insert','finiquitos','2025-04-17 00:34:28',3),(9,2,'insert','finiquitodetalle','2025-04-17 00:34:28',2),(10,2,'update','finiquitos','2025-04-17 10:28:43',3),(11,2,'insert','finiquitodetalle','2025-04-17 10:28:46',3),(12,2,'insert','anexocontrato','2025-04-17 23:41:41',1),(13,2,'insert','anexocontrato','2025-04-17 23:48:09',2),(14,2,'delete','anexocontrato','2025-04-17 23:51:56',2),(15,2,'insert','anexocontrato','2025-04-17 23:54:58',3),(16,2,'delete','anexocontrato','2025-04-17 23:55:18',3),(17,2,'insert','anexocontrato','2025-04-17 23:57:30',4),(18,2,'delete','anexocontrato','2025-04-18 00:10:28',4),(19,2,'insert','anexocontrato','2025-04-18 00:17:48',5),(20,2,'delete','anexocontrato','2025-04-18 00:24:26',5),(21,2,'insert','anexocontrato','2025-04-18 00:24:51',6),(22,2,'delete','anexocontrato','2025-04-18 00:26:57',6),(23,2,'insert','anexocontrato','2025-04-18 00:36:36',7),(24,2,'delete','anexocontrato','2025-04-18 00:37:01',7),(25,2,'insert','anexocontrato','2025-04-18 01:04:19',8),(26,2,'insert','ArchivosEmpresa','2025-04-18 01:35:10',9),(27,2,'delete','ArchivosEmpresa','2025-04-18 01:37:47',9),(28,2,'delete','tareasempleadosregistro','2025-04-20 22:24:20',0),(29,2,'insert','tareasempleadosregistro','2025-04-20 22:24:20',37),(30,2,'delete','tareasempleadosasistencia','2025-04-20 22:25:15',0),(31,2,'insert','tareasempleadosasistencia','2025-04-20 22:25:15',24),(32,2,'delete','tareasempleadosasistencia','2025-04-28 22:03:40',0),(33,2,'insert','tareasempleadosasistencia','2025-04-28 22:03:40',25),(34,2,'delete','tareasempleadosregistro','2025-04-28 22:03:59',0),(35,2,'insert','tareasempleadosregistro','2025-04-28 22:03:59',38),(36,2,'delete','tareasempleadosasistencia','2025-04-29 21:59:24',0),(37,2,'insert','tareasempleadosasistencia','2025-04-29 21:59:24',26);
/*!40000 ALTER TABLE `historialacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jornadas`
--

DROP TABLE IF EXISTS `jornadas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jornadas` (
  `idJornadas` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `DiaComienzo` varchar(45) DEFAULT NULL,
  `DiaTermino` varchar(45) DEFAULT NULL,
  `HoraInSemana` varchar(45) DEFAULT NULL,
  `HoraOutSemana` varchar(45) DEFAULT NULL,
  `HoraInFinSemana` varchar(45) DEFAULT NULL,
  `HoraOutFinSemana` varchar(45) DEFAULT NULL,
  `Fecha_creacion` datetime DEFAULT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `HorasSemanales` int DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  PRIMARY KEY (`idJornadas`),
  KEY `fk_jornada_empresa_idx` (`IdEmpresa`),
  CONSTRAINT `fk_jornada_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jornadas`
--

LOCK TABLES `jornadas` WRITE;
/*!40000 ALTER TABLE `jornadas` DISABLE KEYS */;
INSERT INTO `jornadas` VALUES (1,'Jornada Semanal','Lunes','Viernes','09:00','18:00',NULL,NULL,'2025-03-06 13:14:31','admin1',44,3),(2,'Jornada Completa','Lunes','Sabado','09:00','17:00','09:00','13:00','2025-03-06 13:14:39','admin1',44,3),(5,'Hora Chef','Lunes','Sabado','09:00','14:00','09:00','14:00','2025-03-31 00:33:15','2',30,3);
/*!40000 ALTER TABLE `jornadas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `liquidaciones`
--

DROP TABLE IF EXISTS `liquidaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `liquidaciones` (
  `IdLiquidacion` int NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int NOT NULL,
  `Periodo` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `SalarioBase` decimal(18,2) NOT NULL,
  `Bonificaciones` decimal(18,2) DEFAULT '0.00',
  `Deducciones` decimal(18,2) DEFAULT '0.00',
  `SueldoLiquido` decimal(18,2) NOT NULL,
  `FechaGeneracion` datetime DEFAULT CURRENT_TIMESTAMP,
  `IdEmpresa` int DEFAULT NULL,
  `IdContrato` int DEFAULT NULL,
  `year` varchar(45) DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  `DescripcionBonos` varchar(5000) DEFAULT NULL,
  `DescripcionDeducciones` varchar(5000) DEFAULT NULL,
  PRIMARY KEY (`IdLiquidacion`),
  KEY `fk_liquidaciones_empleados` (`IdEmpleado`),
  KEY `fk_liquidacion_empresa_idx` (`IdEmpresa`),
  KEY `fk_liquidacion_contrato_idx` (`IdContrato`),
  CONSTRAINT `fk_liquidacion_contrato` FOREIGN KEY (`IdContrato`) REFERENCES `contratos` (`IdContrato`),
  CONSTRAINT `fk_liquidacion_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`),
  CONSTRAINT `fk_liquidaciones_empleados` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `liquidaciones`
--

LOCK TABLES `liquidaciones` WRITE;
/*!40000 ALTER TABLE `liquidaciones` DISABLE KEYS */;
INSERT INTO `liquidaciones` VALUES (1,4,'marzo de 2025',235500.00,55000.00,200000.00,90500.00,'2025-04-22 13:06:20',3,6,'2025','4','Gratificacion   $25000,00\r\nBono Colacion 2   $30000,00\r\nTotal Bonificaciones: $55000,00','Prestamo JOSE   $200000,00\r\nTotal Deducciones: $200000,00'),(14,5,'marzo de 2025',282000.00,60000.00,50000.00,292000.00,'2025-04-25 20:29:47',3,7,'2025','4','<table style=\'border-collapse: collapse; font-family: monospace; width: 100%;\'>[[SUELDOBASE]]\r\n                <tr>\r\n                    <td style=\'text-align: left;\'>Bono Gratificacion</td>\r\n                    <td style=\'text-align: right;\'>30.000</td>\r\n                </tr>\r\n            <tr>\r\n                <td style=\'text-align: left; font-weight: bold;\'>TOTAL IMPONIBLE</td>\r\n                <td style=\'text-align: right; font-weight: bold;\'>[[TOTALIMPONIBLE]]</td>\r\n            </tr>\r\n                <tr>\r\n                    <td style=\'text-align: left;\'>Bono Colacion 2</td>\r\n                    <td style=\'text-align: right;\'>30.000</td>\r\n                </tr>\r\n            [[CARGASFAMILIARES]]\r\n            <tr>\r\n                <td style=\'text-align: left; font-weight: bold;\'>TOTAL NO IMPONIBLE</td>\r\n                <td style=\'text-align: right;font-weight: bold;\'>[[TOTALNOIMPONIBLE]]</td>\r\n            </tr></table>','<table style=\'border-collapse: collapse; font-family: monospace; width: 100%;\'>[[HFALTANTES]]\r\n                <tr>\r\n                    <td style=\'text-align: left;\'>Anticipo</td>\r\n                    <td style=\'text-align: right;\'>50.000</td>\r\n                </tr>\r\n            <tr>\r\n                <td style=\'text-align: left; font-weight: bold;\'>TOTAL OTROS DESC.</td>\r\n                <td style=\'text-align: right; font-weight: bold;\'>50.000</td>\r\n            </tr>\r\n            [[DESCUENTOSLEGALES]]\r\n            <tr>\r\n                <td style=\'text-align: left; font-weight: bold;\'>TOTAL DESC. LEGALES</td>\r\n                <td style=\'text-align: right;\'>[[TOTALDESCLEGALES]]</td>\r\n            </tr></table>');
/*!40000 ALTER TABLE `liquidaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_asignacionesetareas`
--

DROP TABLE IF EXISTS `log_asignacionesetareas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_asignacionesetareas` (
  `IdLogAsig` int NOT NULL AUTO_INCREMENT,
  `IdAsignacion` int NOT NULL,
  `IdEmpleado` int NOT NULL,
  `FechaInicio` datetime NOT NULL,
  `FechaTermino` datetime DEFAULT NULL,
  `Usuario` varchar(45) NOT NULL,
  `Fecha_Creacion` varchar(45) NOT NULL,
  PRIMARY KEY (`IdLogAsig`),
  KEY `fk_LogAsig_empleados__empleados_idx` (`IdEmpleado`),
  CONSTRAINT `fk_LogAsig_empleados__empleados` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_asignacionesetareas`
--

LOCK TABLES `log_asignacionesetareas` WRITE;
/*!40000 ALTER TABLE `log_asignacionesetareas` DISABLE KEYS */;
INSERT INTO `log_asignacionesetareas` VALUES (3,3,2,'2025-03-05 23:33:08','2025-03-05 23:36:36','admin1','2025-03-05 23:36:27'),(4,4,2,'2025-03-07 17:23:34',NULL,'admin1','2025-03-07 17:23:38'),(5,5,4,'2025-03-08 12:54:00',NULL,'javiLuna','2025-03-08 12:54:04'),(6,6,4,'2025-03-12 22:06:00',NULL,'javiLuna','2025-03-12 22:06:02'),(7,7,5,'2025-03-16 22:09:06',NULL,'javiLuna','2025-03-16 22:09:09'),(8,8,5,'2025-03-19 23:13:18',NULL,'javiLuna','2025-03-19 23:13:20');
/*!40000 ALTER TABLE `log_asignacionesetareas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logs` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  `Nivel` varchar(50) DEFAULT NULL,
  `Logger` varchar(255) DEFAULT NULL,
  `Mensaje` text,
  `Exception` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` VALUES (1,'2025-04-21 09:55:56','INFO','TestLogger','Probando log desde c√≥digo',NULL),(2,'2025-04-21 10:23:48','Info','TestLogger','Mensaje desde c√≥digo',NULL),(3,'2025-04-21 11:00:14','Info','PeopleFlow.Program','Probando log a consola, archivo y base de datos',''),(4,'2025-04-21 11:01:33','Info','PeopleFlow.Program','Aplicaci√≥n iniciada',''),(5,'2025-04-21 11:01:33','Error','PeopleFlow.Program','Probando escritura en MySQL','System.Exception: Excepci√≥n de prueba'),(6,'2025-04-21 11:01:32','Info','TestLogger','Mensaje desde c√≥digo',NULL),(7,'2025-04-21 11:02:53','Info','PeopleFlow.Program','Aplicaci√≥n iniciada',''),(8,'2025-04-21 19:43:58','Error','PeopleFlow.Formularios.FrmTareas','Error al intentar Grabar tarea: FrmTareas','System.FormatException: The input string \'100m\' was not in a correct format.\r\n   at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)\r\n   at System.Number.ParseDecimal[TChar](ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info)\r\n   at System.Convert.ToDecimal(String value)\r\n   at PeopleFlow.Formularios.FrmTareas.btnRegistrar_Click(Object sender, EventArgs e) in C:\\Users\\Kyousukee\\source\\repos\\PeopleFlow\\PeopleFlow\\Formularios\\TareasForm\\FrmTareas.cs:line 134');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plazos`
--

DROP TABLE IF EXISTS `plazos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `plazos` (
  `IdPlazo` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `Fecha_creacion` datetime DEFAULT NULL,
  PRIMARY KEY (`IdPlazo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plazos`
--

LOCK TABLES `plazos` WRITE;
/*!40000 ALTER TABLE `plazos` DISABLE KEYS */;
INSERT INTO `plazos` VALUES (3,'Dias',_binary '','2025-03-06 00:54:28'),(4,'Mes',_binary '','2025-03-06 00:54:28'),(5,'A√±os',_binary '','2025-03-06 00:54:28');
/*!40000 ALTER TABLE `plazos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `regimensalud`
--

DROP TABLE IF EXISTS `regimensalud`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `regimensalud` (
  `idRegimenSalud` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  PRIMARY KEY (`idRegimenSalud`),
  KEY `fk_salud_empresa_idx` (`IdEmpresa`),
  CONSTRAINT `fk_salud_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `regimensalud`
--

LOCK TABLES `regimensalud` WRITE;
/*!40000 ALTER TABLE `regimensalud` DISABLE KEYS */;
INSERT INTO `regimensalud` VALUES (1,'R√©gimen antiguo ',_binary '','2025-03-07 00:07:26',1),(2,'R√©gimen nuevo A.F.P',_binary '','2025-03-07 00:07:26',1),(3,'FONASA',_binary '','2025-03-07 00:07:26',1),(4,'ISAPRE ',_binary '','2025-03-07 00:07:26',1);
/*!40000 ALTER TABLE `regimensalud` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `IdRol` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `Estado` bit(1) DEFAULT b'1',
  `IdEmpresa` int DEFAULT NULL,
  PRIMARY KEY (`IdRol`),
  UNIQUE KEY `Descripcion` (`Descripcion`),
  KEY `fk_rol_empresa_idx` (`IdEmpresa`),
  CONSTRAINT `fk_rol_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador','2025-03-03 23:24:50',_binary '',3),(2,'RRHH','2025-03-03 23:24:50',_binary '',3),(3,'Empleado','2025-03-03 23:24:50',_binary '',3),(4,'Chef','2025-03-30 22:54:00',_binary '',3);
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tareas`
--

DROP TABLE IF EXISTS `tareas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tareas` (
  `IdTarea` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(500) NOT NULL,
  `FechaAsignacion` date NOT NULL,
  `FechaFinalizacion` date DEFAULT NULL,
  `IdEstadoTarea` int NOT NULL,
  `IdTipoPago` int NOT NULL,
  `Valor` decimal(18,2) NOT NULL,
  `FechaModificacion` datetime NOT NULL,
  `Titulo` varchar(45) DEFAULT NULL,
  `IdJornada` int DEFAULT NULL,
  `IdEmpresa` int DEFAULT NULL,
  PRIMARY KEY (`IdTarea`),
  KEY `fk_tareas_estados` (`IdEstadoTarea`),
  KEY `fk_tareas_tipo_pago` (`IdTipoPago`),
  KEY `fk_tareas_jornada_idx` (`IdJornada`),
  KEY `fk_tarea_empresa_idx` (`IdEmpresa`),
  CONSTRAINT `fk_tarea_empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`),
  CONSTRAINT `fk_tareas_estados` FOREIGN KEY (`IdEstadoTarea`) REFERENCES `estadostarea` (`IdEstadoTarea`),
  CONSTRAINT `fk_tareas_jornada` FOREIGN KEY (`IdJornada`) REFERENCES `jornadas` (`idJornadas`),
  CONSTRAINT `fk_tareas_tipo_pago` FOREIGN KEY (`IdTipoPago`) REFERENCES `tipopago` (`IdTipoPago`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tareas`
--

LOCK TABLES `tareas` WRITE;
/*!40000 ALTER TABLE `tareas` DISABLE KEYS */;
INSERT INTO `tareas` VALUES (3,'se reparan bins de plasticos con maquinaria.','2025-03-06','2026-03-06',2,5,2500.00,'2025-03-06 13:42:22','Reparacion de bins',1,1),(4,'adasd','2025-03-06','2026-03-06',1,5,350.00,'2025-03-06 14:11:18','Lavado de Bins',2,1),(5,'Se rellena pasteles con cremas.','2025-03-08','2029-03-08',2,3,3000.00,'2025-03-31 01:21:45','Relleno de Pasteles',1,3),(6,'Cocinar galleta','2025-03-09','2026-03-09',2,5,500.00,'2025-03-09 23:22:52','Cocinar Galleta',1,3),(7,'Hacer todo el proceso del kuchen','2025-03-18','2027-03-18',2,4,10000.00,'2025-03-22 12:00:20','Hacer kuchen',2,3);
/*!40000 ALTER TABLE `tareas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tareascontrolcambios`
--

DROP TABLE IF EXISTS `tareascontrolcambios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tareascontrolcambios` (
  `IdCambioTarea` int NOT NULL AUTO_INCREMENT,
  `IdTarea` int NOT NULL,
  `IdTipoPago` int NOT NULL,
  `fechaInicio` datetime NOT NULL,
  `FechaTermino` datetime DEFAULT NULL,
  `Valor` decimal(18,2) NOT NULL,
  `IdEstadoTarea` int NOT NULL,
  PRIMARY KEY (`IdCambioTarea`),
  KEY `fk_Control_Tareas_idx` (`IdTarea`),
  KEY `fk_Control_Pago_idx` (`IdTipoPago`),
  KEY `fk_Control_Estado_idx` (`IdEstadoTarea`),
  CONSTRAINT `fk_Control_Estado` FOREIGN KEY (`IdEstadoTarea`) REFERENCES `estadostarea` (`IdEstadoTarea`),
  CONSTRAINT `fk_Control_Pago` FOREIGN KEY (`IdTipoPago`) REFERENCES `tipopago` (`IdTipoPago`),
  CONSTRAINT `fk_Control_Tareas` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tareascontrolcambios`
--

LOCK TABLES `tareascontrolcambios` WRITE;
/*!40000 ALTER TABLE `tareascontrolcambios` DISABLE KEYS */;
INSERT INTO `tareascontrolcambios` VALUES (3,4,5,'2025-03-06 13:46:59','2025-03-06 14:01:35',350.00,1),(4,4,5,'2025-03-06 14:01:35','2025-03-06 14:11:18',350.00,1),(5,5,1,'2025-03-08 12:53:49','2025-03-14 18:34:37',3000.00,2),(6,7,2,'2025-03-18 22:26:02','2025-03-18 22:40:19',6000.00,2),(7,7,3,'2025-03-18 22:40:19','2025-03-19 23:13:38',10000.00,2),(8,7,2,'2025-03-19 23:13:38','2025-03-20 21:01:43',10000.00,2),(9,7,4,'2025-03-20 21:01:43','2025-03-22 12:00:20',10000.00,2),(10,5,5,'2025-03-14 18:34:37','2025-03-31 01:21:45',3000.00,2);
/*!40000 ALTER TABLE `tareascontrolcambios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tareasempleados`
--

DROP TABLE IF EXISTS `tareasempleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tareasempleados` (
  `IdTareaEmpl` int NOT NULL AUTO_INCREMENT,
  `Idtarea` int NOT NULL,
  `IdEmpleador` int NOT NULL,
  `FechaIni` datetime DEFAULT NULL,
  `FechaFin` datetime DEFAULT NULL,
  `Usuario` varchar(45) NOT NULL,
  PRIMARY KEY (`IdTareaEmpl`),
  KEY `fk_tareas_empleados_fk_tareas_empleados_empleado_idx` (`IdEmpleador`),
  KEY `fk_tareas_empleados_fk_tareas_empleados_tarea_idx` (`Idtarea`),
  CONSTRAINT `fk_tareas_empleados_fk_tareas_empleados_empleado` FOREIGN KEY (`IdEmpleador`) REFERENCES `empleados` (`IdEmpleado`),
  CONSTRAINT `fk_tareas_empleados_fk_tareas_empleados_tarea` FOREIGN KEY (`Idtarea`) REFERENCES `tareas` (`IdTarea`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tareasempleados`
--

LOCK TABLES `tareasempleados` WRITE;
/*!40000 ALTER TABLE `tareasempleados` DISABLE KEYS */;
INSERT INTO `tareasempleados` VALUES (4,3,2,'2025-03-07 17:23:34','0001-01-01 00:00:00','admin1'),(5,5,4,'2025-03-08 12:54:00','0001-01-01 00:00:00','javiLuna'),(6,6,4,'2025-03-12 22:06:00','0001-01-01 00:00:00','javiLuna'),(8,7,5,'2025-03-19 23:13:18','0001-01-01 00:00:00','javiLuna');
/*!40000 ALTER TABLE `tareasempleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tareasempleadosasistencia`
--

DROP TABLE IF EXISTS `tareasempleadosasistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tareasempleadosasistencia` (
  `IdTareaAsistencia` int NOT NULL AUTO_INCREMENT,
  `IdTarea` int NOT NULL,
  `IdEmpleado` int NOT NULL,
  `HoraInicio` varchar(5) DEFAULT NULL,
  `HoraTermino` varchar(5) DEFAULT NULL,
  `FechaAsignacion` date DEFAULT NULL,
  PRIMARY KEY (`IdTareaAsistencia`),
  KEY `fk_tareas_empleados_tarea` (`IdTarea`),
  KEY `fk_tareas_empleados_empleado` (`IdEmpleado`),
  CONSTRAINT `fk_tareas_empleados_Asistencia` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`),
  CONSTRAINT `fk_tareas_empleados_tarea_Asistencia` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tareasempleadosasistencia`
--

LOCK TABLES `tareasempleadosasistencia` WRITE;
/*!40000 ALTER TABLE `tareasempleadosasistencia` DISABLE KEYS */;
INSERT INTO `tareasempleadosasistencia` VALUES (17,7,5,'09:00','18:00','2025-03-20'),(18,7,5,'09:00','18:00','2025-03-21'),(19,7,5,'09:00','15:00','2025-03-22'),(20,7,5,'09:00','17:00','2025-03-25'),(21,7,5,'09:00','17:00','2025-03-24'),(22,7,5,'09:00','17:00','2025-03-27'),(23,7,5,'09:00','17:00','2025-03-28'),(24,7,5,'09:00','17:00','2025-04-17'),(25,5,4,'09:00','18:00','2025-04-28'),(26,5,4,'09:00','18:00','2025-04-29');
/*!40000 ALTER TABLE `tareasempleadosasistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tareasempleadosregistro`
--

DROP TABLE IF EXISTS `tareasempleadosregistro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tareasempleadosregistro` (
  `IdTareaEmpleado` int NOT NULL AUTO_INCREMENT,
  `IdTarea` int NOT NULL,
  `IdEmpleado` int NOT NULL,
  `Cantidad` int DEFAULT '0',
  `PagoIndividual` decimal(18,2) NOT NULL,
  `FechaAsignacion` date DEFAULT NULL,
  PRIMARY KEY (`IdTareaEmpleado`),
  KEY `fk_tareas_empleados_tarea` (`IdTarea`),
  KEY `fk_tareas_empleados_empleado` (`IdEmpleado`),
  CONSTRAINT `fk_tareas_empleados_empleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`),
  CONSTRAINT `fk_tareas_empleados_tarea` FOREIGN KEY (`IdTarea`) REFERENCES `tareas` (`IdTarea`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tareasempleadosregistro`
--

LOCK TABLES `tareasempleadosregistro` WRITE;
/*!40000 ALTER TABLE `tareasempleadosregistro` DISABLE KEYS */;
INSERT INTO `tareasempleadosregistro` VALUES (6,6,4,10,0.00,'2025-03-17'),(7,5,4,10,0.00,'2025-03-17'),(8,5,5,10,0.00,'2025-03-17'),(10,5,5,5,0.00,'2025-03-18'),(12,6,4,3,0.00,'2025-03-18'),(13,7,5,1,0.00,'2025-03-19'),(14,6,4,2,0.00,'2025-03-19'),(15,5,4,2,0.00,'2025-03-19'),(16,5,5,2,2000.00,'2025-03-19'),(17,5,4,7,0.00,'2025-03-21'),(18,5,5,7,0.00,'2025-03-21'),(19,6,4,7,0.00,'2025-03-21'),(20,5,4,32,0.00,'2025-03-22'),(21,5,5,32,0.00,'2025-03-22'),(23,6,4,23,0.00,'2025-03-22'),(24,5,4,20,0.00,'2025-03-18'),(25,5,4,10,0.00,'2025-03-25'),(26,5,5,10,0.00,'2025-03-25'),(27,6,4,4,0.00,'2025-03-25'),(28,5,4,8,0.00,'2025-03-24'),(29,5,5,8,0.00,'2025-03-24'),(30,6,4,4,0.00,'2025-03-24'),(31,5,4,6,0.00,'2025-03-27'),(32,5,5,6,0.00,'2025-03-27'),(33,6,4,20,0.00,'2025-03-27'),(34,5,4,40,0.00,'2025-03-28'),(35,5,5,40,0.00,'2025-03-28'),(36,6,4,20,3000.00,'2025-03-28'),(37,6,4,59,0.00,'2025-04-20'),(38,6,4,10,0.00,'2025-04-28');
/*!40000 ALTER TABLE `tareasempleadosregistro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocontratos`
--

DROP TABLE IF EXISTS `tipocontratos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipocontratos` (
  `IdTipoContrato` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Estado` bit(1) DEFAULT NULL,
  `FechaCreacion` datetime DEFAULT NULL,
  `Planilla` text,
  PRIMARY KEY (`IdTipoContrato`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipocontratos`
--

LOCK TABLES `tipocontratos` WRITE;
/*!40000 ALTER TABLE `tipocontratos` DISABLE KEYS */;
INSERT INTO `tipocontratos` VALUES (1,'Plazo Fijo',_binary '','2025-03-05 23:54:18','\n\n \n  <center><strong>CONTRATO DE PLAZO FIJO</strong></center>\n  <p>En la ciudad de [[CIUDAD]], a [[DIA]] del mes de [[MES]] de [[YEAR]], entre la Empresa [[RAZON_SOCIAL]], R.U.T. N&deg; [[RUT_EMPRESA]], representada por don(&ntilde;a) [[NOMBRE_ENCAEGADO]], RUT N&deg; [[RUT_ENCARGADO]], en su calidad de [[CARGO_ENCARGADO]], ambos con domicilio para estos efectos en [[DIRECCION_ACUERDO]], correo electr&oacute;nico [[CORREO_ENCARGADO]], en adelante \"el empleador\" y don (&ntilde;a) [[NOMBRE_TRABAJADOR]], R.U.T. N&deg; [[RUT_TRABAJADOR]], nacido (a) el [[FECHA_NACIMIENTOT]], de nacionalidad [[NACIONALIDAD]], de profesi&oacute;n (u oficio) [[PROFESION]], de estado civil [[ESTADO_CIVIL]], domiciliado en [[DIRECCION_EMPLEADO]], correo electr&oacute;nico [[CORREO_EMPLEADO]], en adelante \"el/la trabajador(a)\", se ha convenido el siguiente contrato de trabajo.</p>\n  <p><strong>PRIMERO.</strong> &ndash; El/La trabajador(a) se compromete y obliga a ejecutar el trabajo de [[TAREA_ASIGNADA]] que se le encomienda. Los servicios se prestar&aacute;n en sitios o propiedades donde el empleador tenga acuerdos, sin perjuicio de la facultad del empleador de alterar, por causa justificada, la naturaleza de los servicios, o el sitio o recinto en que ellos han de prestarse, con la sola limitaci&oacute;n de que se trate de labores similares y que el nuevo sitio o recinto quede dentro de la misma localidad o ciudad, conforme a lo se&ntilde;alado en el art&iacute;culo 12&ordm; del C&oacute;digo del Trabajo.</p>\n  <p><strong>SEGUNDO.</strong> - La jornada de trabajo ser&aacute; de [[HORAS_SEMANALES]] semanales distribuidas de [[DIA_INICIO]] a [[DIA_TERMINO]], de [[HORA_INICIO]] a [[HORA_TERMINO]] horas [[HORARIO_FINDESEMANA]] y accediendo a 1 hora de colaci&oacute;n en la semana. El tiempo de 1 hora para colaci&oacute;n ser&aacute; de cargo del/la trabajadora.</p>\n  <p><strong>TERCERO.</strong> - El empleador se compromete a remunerar los servicios del/la trabajador(a) con un sueldo mensual se calculara de la siguiente manera [[TIPO_PAGO]] que ser&aacute; liquidado y pagado, por per&iacute;odos vencidos y en forma proporcional a los d&iacute;as trabajados. El pago de la remuneraci&oacute;n, se har&aacute; en dinero efectivo/transferencia y/o deposito.</p>\n  <p><strong>CUARTO.</strong> - El empleador se compromete a otorgar al trabajador(a) los siguientes beneficios [[BENEFICIOS]]</p>\n  <p><strong>QUINTO.</strong> &ndash; El/La trabajador(a) se compromete y obliga expresamente a cumplir las instrucciones que le sean impartidas por su jefe inmediato o por la gerencia de la empresa, en relaci&oacute;n a su trabajo y acatar en todas sus partes las normas del Reglamento Interno de Orden, Higiene y Seguridad (de existir en la empresa), las que declara conocer y que forman parte integrante del presente contrato, reglamento del cual se le entrega un ejemplar.</p>\n  <p><strong>SEXTO.</strong> - El presente contrato durar&aacute; hasta el [[FECHA_FIN]] y s&oacute;lo podr&aacute; pon&eacute;rsele t&eacute;rmino en conformidad a la legislaci&oacute;n vigente.</p>\n  <p><strong>SEPTIMO.</strong> - Se deja constancia que el trabajador ingres&oacute; al servicio del empleador el [[FECHA_INICIO]]</p>\n  <p><strong>OCTAVO.</strong> - El presente contrato se firma en [[NEJEMPLARES]] ejemplares, declarando el trabajador haber recibido en este acto un ejemplar de dicho instrumento, que es el fiel reflejo de la relaci&oacute;n laboral convenida. El empleador se obliga a mantener en el lugar de trabajo un ejemplar firmado de este contrato, asimismo, deber&aacute; registrar este contrato en el sitio web de la Direcci&oacute;n del Trabajo (www.direcciondeltrabajo.cl).</p>\n  <p><strong>NOVENO.</strong> - Para todos los efectos derivados del presente contrato las partes fijan domicilio en la ciudad de Rancagua y se someten a la Jurisdicci&oacute;n de sus Tribunales.</p>\n  <p><strong><u>DECIMO:</u></strong> El trabajar no se encontrar&aacute; autorizado para trabajar horas extraordinarias, sin autorizaci&oacute;n expresa del empleador.</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <table>\n  <tbody>\n  <tr>\n  <td width=\"312\">\n  <p>...........................................</p>\n  <p>FIRMA TRABAJADOR(A)</p>\n  <p>&nbsp;</p>\n  <p>RUT ...........................................</p>\n  </td>\n  <td width=\"312\">\n  <p>...........................................</p>\n  <p>FIRMA EMPLEADOR</p>\n  <p>&nbsp;</p>\n  <p>RUT ...........................................</p>\n  </td>\n  </tr>\n  </tbody>\n  </table>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p><em>NOTA:</em> <br /> (1) Ley N&deg;21.327, de Modernizaci&oacute;n de la Direcci&oacute;n del Trabajo. Se agreg&oacute; en el numeral 2 del inciso primero del art&iacute;culo 10, del Contrato de Trabajo a continuaci&oacute;n de la palabra \"nacionalidad\", la siguiente frase: \", domicilio y direcci&oacute;n de correo electr&oacute;nico de ambas partes, si la tuvieren\".<br /> (2) Art&iacute;culo 22, inciso 1&deg;, duraci&oacute;n de la jornada ordinaria de trabajo. Modificado por la Ley N&deg;21.561. A contar del 26.04.2024, la jornada de trabajo no exceder&aacute; de cuarenta y cuatro horas. Su distribuci&oacute;n se podr&aacute; efectuar en cada semana calendario o sobre la base de promedios semanales en lapsos de hasta cuatro semanas, en cuyo caso la jornada ordinaria no podr&aacute; exceder de cuarenta y cinco horas ordinarias en cada semana, ni extenderse con este l&iacute;mite por m&aacute;s de dos semanas.<br /> (3) Modalidad alternativa de pago: de acuerdo con el inciso segundo del Art&iacute;culo 54 del C&oacute;digo del Trabajo, modificado por la Ley 21.327 &ldquo;A solicitud del trabajador(a), el pago podr&aacute; realizarse por medio de cheque, o vale vista bancario a su nombre, o transferencia electr&oacute;nica a la cuenta bancaria del trabajador, sin que ello importe costo alguno para &eacute;l. Ejemplo: El pago al trabajador/a, se realizar&aacute; mediante transferencia electr&oacute;nica a la siguiente cuenta:</p>\n  <p>Banco:[[BANCO]]</p>\n  <p>Tipo y n&uacute;mero de cuenta: [[TIPOCUENTA]]</p>\n  <p>Rut: [[RUT_TRABAJADOR]]</p>\n  <p>Correo electr&oacute;nico: [[CORREO_EMPLEADO]]</p>\n  <p><br /> (4) Este tipo de contrato se rige por las normas contempladas en el art. 159 N&ordm; 4 del C&oacute;digo del Trabajo, debiendo tenerse presente lo siguiente:<br /> &bull; La duraci&oacute;n del contrato de plazo, fijo, no podr&aacute; exceder de un a&ntilde;o, salvo que se tratare de gerentes o personas que tengan un t&iacute;tulo profesional o t&eacute;cnico, otorgado por instituciones de educaci&oacute;n superior del Estado o reconocido por &eacute;ste, caso en el cual la duraci&oacute;n no podr&aacute; exceder de dos a&ntilde;os.<br /> &bull; La prestaci&oacute;n de servicios una vez expirado el plazo lo transforma en contrato de duraci&oacute;n indefinida.<br /> &bull; Estos contratos s&oacute;lo admiten una renovaci&oacute;n. La segunda renovaci&oacute;n lo transforma en contrato de duraci&oacute;n indefinida.<br /> &bull; La prestaci&oacute;n de servicios discontinuos durante 12 meses o m&aacute;s en un per&iacute;odo de quince meses hace presumir que hay contrato indefinido.<br /> &bull; En los contratos que tengan una duraci&oacute;n de 30 d&iacute;as o menos, se entiende incluida en la remuneraci&oacute;n convenida el pago por feriado y dem&aacute;s derechos que se devengan en proporci&oacute;n al tiempo servido. Regir&aacute; la misma disposici&oacute;n si el contrato inicial ha tenido pr&oacute;rrogas, que en total incluido el primer per&iacute;odo no exceda de 60 d&iacute;as.<br /> &bull; La terminaci&oacute;n anticipada del contrato a plazo fijo, sin que exista causal justificada obliga al empleador a pagar la totalidad de los emolumentos convenidos hasta la fecha de t&eacute;rmino consignada en el contrato.<br /> (5) Ley N&deg;21.327, que agrega el art&iacute;culo 9 bis, que establece: &ldquo;En conformidad a lo dispuesto en el art&iacute;culo 515, el empleador deber&aacute; registrar en el sitio electr&oacute;nico de la Direcci&oacute;n del Trabajo los contratos de trabajo, dentro de los quince d&iacute;as siguientes a su celebraci&oacute;n.&rdquo;</p>\n \n\n'),(2,'Indefinido',_binary '','2025-03-05 23:54:18','\n\n \n  <center><strong>CONTRATO&nbsp;INDEFINIDO</strong></center>\n  <p>En la ciudad de [[CIUDAD]], a [[DIA]] del mes de [[MES]] de [[YEAR]], entre la Empresa [[RAZON_SOCIAL]], R.U.T. N&deg; [[RUT_EMPRESA]], representada por don(&ntilde;a) [[NOMBRE_ENCAEGADO]], RUT N&deg; [[RUT_ENCARGADO]], en su calidad de [[CARGO_ENCARGADO]], ambos con domicilio para estos efectos en [[DIRECCION_ACUERDO]], correo electr&oacute;nico [[CORREO_ENCARGADO]], en adelante \"el empleador\" y don (&ntilde;a) [[NOMBRE_TRABAJADOR]], R.U.T. N&deg; [[RUT_TRABAJADOR]], nacido (a) el [[FECHA_NACIMIENTOT]], de nacionalidad [[NACIONALIDAD]], de profesi&oacute;n (u oficio) [[PROFESION]], de estado civil [[ESTADO_CIVIL]], domiciliado en [[DIRECCION_EMPLEADO]], correo electr&oacute;nico [[CORREO_EMPLEADO]], en adelante \"el/la trabajador(a)\", se ha convenido el siguiente contrato de trabajo.</p>\n  <p><strong>PRIMERO.</strong> &ndash; El/La trabajador(a) se compromete y obliga a ejecutar el trabajo de [[TAREA_ASIGNADA]] que se le encomienda. Los servicios se prestar&aacute;n en sitios o propiedades donde el empleador tenga acuerdos, sin perjuicio de la facultad del empleador de alterar, por causa justificada, la naturaleza de los servicios, o el sitio o recinto en que ellos han de prestarse, con la sola limitaci&oacute;n de que se trate de labores similares y que el nuevo sitio o recinto quede dentro de la misma localidad o ciudad, conforme a lo se&ntilde;alado en el art&iacute;culo 12&ordm; del C&oacute;digo del Trabajo.</p>\n  <p><strong>SEGUNDO.</strong> - La jornada de trabajo ser&aacute; de [[HORAS_SEMANALES]] semanales distribuidas de [[DIA_INICIO]] a [[DIA_TERMINO]], de [[HORA_INICIO]] a [[HORA_TERMINO]] horas [[HORARIO_FINDESEMANA]] y accediendo a 1 hora de colaci&oacute;n en la semana. El tiempo de 1 hora para colaci&oacute;n ser&aacute; de cargo del/la trabajadora.</p>\n  <p><strong>TERCERO.</strong> - El empleador se compromete a remunerar los servicios del/la trabajador(a) con un sueldo mensual se calculara de la siguiente manera [[TIPO_PAGO]] que ser&aacute; liquidado y pagado, por per&iacute;odos vencidos y en forma proporcional a los d&iacute;as trabajados. El pago de la remuneraci&oacute;n, se har&aacute; en dinero efectivo/transferencia y/o deposito.</p>\n  <p><strong>CUARTO.</strong> - El empleador se compromete a otorgar al trabajador(a) los siguientes beneficios [[BENEFICIOS]]</p>\n  <p><strong>QUINTO.</strong> &ndash; El/La trabajador(a) se compromete y obliga expresamente a cumplir las instrucciones que le sean impartidas por su jefe inmediato o por la gerencia de la empresa, en relaci&oacute;n a su trabajo y acatar en todas sus partes las normas del Reglamento Interno de Orden, Higiene y Seguridad (de existir en la empresa), las que declara conocer y que forman parte integrante del presente contrato, reglamento del cual se le entrega un ejemplar.</p>\n  <p><strong>SEXTO.</strong> - El presente contrato tendr&aacute; el car&aacute;cter de contrato <strong>indefinido</strong>. Las partes pueden ponerle t&eacute;rmino de com&uacute;n acuerdo, y una sola de ellas podr&aacute; hacerlo en la forma, las condiciones y por las causales que se&ntilde;alan los art&iacute;culos 159, 160 y 161 del C&oacute;digo del Trabajo.</p>\n  <p><strong>SEPTIMO.</strong> - Se deja constancia que el trabajador ingres&oacute; al servicio del empleador el [[FECHA_INICIO]]</p>\n  <p><strong>OCTAVO.</strong> - El presente contrato se firma en [[NEJEMPLARES]] ejemplares, declarando el trabajador haber recibido en este acto un ejemplar de dicho instrumento, que es el fiel reflejo de la relaci&oacute;n laboral convenida. El empleador se obliga a mantener en el lugar de trabajo un ejemplar firmado de este contrato, asimismo, deber&aacute; registrar este contrato en el sitio web de la Direcci&oacute;n del Trabajo (www.direcciondeltrabajo.cl).</p>\n  <p><strong>NOVENO.</strong> - Para todos los efectos derivados del presente contrato las partes fijan domicilio en la ciudad de Rancagua y se someten a la Jurisdicci&oacute;n de sus Tribunales.</p>\n  <p><strong>DECIMO.</strong>&nbsp;-El trabajar no se encontrar&aacute; autorizado para trabajar horas extraordinarias, sin autorizaci&oacute;n expresa del empleador.</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <table>\n  <tbody>\n  <tr>\n  <td width=\"312\">\n  <p>...........................................</p>\n  <p>FIRMA TRABAJADOR(A)</p>\n  <p>&nbsp;</p>\n  <p>RUT ...........................................</p>\n  </td>\n  <td width=\"312\">\n  <p>...........................................</p>\n  <p>FIRMA EMPLEADOR</p>\n  <p>&nbsp;</p>\n  <p>RUT ...........................................</p>\n  </td>\n  </tr>\n  </tbody>\n  </table>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p><em>NOTA:</em> <br /> (1) Ley N&deg;21.327, de Modernizaci&oacute;n de la Direcci&oacute;n del Trabajo. Se agreg&oacute; en el numeral 2 del inciso primero del art&iacute;culo 10, del Contrato de Trabajo a continuaci&oacute;n de la palabra \"nacionalidad\", la siguiente frase: \", domicilio y direcci&oacute;n de correo electr&oacute;nico de ambas partes, si la tuvieren\".<br /> (2) Art&iacute;culo 22, inciso 1&deg;, duraci&oacute;n de la jornada ordinaria de trabajo. Modificado por la Ley N&deg;21.561. A contar del 26.04.2024, la jornada de trabajo no exceder&aacute; de cuarenta y cuatro horas. Su distribuci&oacute;n se podr&aacute; efectuar en cada semana calendario o sobre la base de promedios semanales en lapsos de hasta cuatro semanas, en cuyo caso la jornada ordinaria no podr&aacute; exceder de cuarenta y cinco horas ordinarias en cada semana, ni extenderse con este l&iacute;mite por m&aacute;s de dos semanas.<br /> (3) Modalidad alternativa de pago: de acuerdo con el inciso segundo del Art&iacute;culo 54 del C&oacute;digo del Trabajo, modificado por la Ley 21.327 &ldquo;A solicitud del trabajador(a), el pago podr&aacute; realizarse por medio de cheque, o vale vista bancario a su nombre, o transferencia electr&oacute;nica a la cuenta bancaria del trabajador, sin que ello importe costo alguno para &eacute;l. Ejemplo: El pago al trabajador/a, se realizar&aacute; mediante transferencia electr&oacute;nica a la siguiente cuenta:</p>\n  <p>Banco:[[BANCO]]</p>\n  <p>Tipo y n&uacute;mero de cuenta: [[TIPOCUENTA]]</p>\n  <p>Rut: [[RUT_TRABAJADOR]]</p>\n  <p>Correo electr&oacute;nico: [[CORREO_EMPLEADO]]</p>\n  <p><br /> (4) Este tipo de contrato se rige por las normas contempladas en el art. 159 N&ordm; 4 del C&oacute;digo del Trabajo, debiendo tenerse presente lo siguiente:<br /> &bull; La duraci&oacute;n del contrato de plazo, fijo, no podr&aacute; exceder de un a&ntilde;o, salvo que se tratare de gerentes o personas que tengan un t&iacute;tulo profesional o t&eacute;cnico, otorgado por instituciones de educaci&oacute;n superior del Estado o reconocido por &eacute;ste, caso en el cual la duraci&oacute;n no podr&aacute; exceder de dos a&ntilde;os.<br /> &bull; La prestaci&oacute;n de servicios una vez expirado el plazo lo transforma en contrato de duraci&oacute;n indefinida.<br /> &bull; Estos contratos s&oacute;lo admiten una renovaci&oacute;n. La segunda renovaci&oacute;n lo transforma en contrato de duraci&oacute;n indefinida.<br /> &bull; La prestaci&oacute;n de servicios discontinuos durante 12 meses o m&aacute;s en un per&iacute;odo de quince meses hace presumir que hay contrato indefinido.<br /> &bull; En los contratos que tengan una duraci&oacute;n de 30 d&iacute;as o menos, se entiende incluida en la remuneraci&oacute;n convenida el pago por feriado y dem&aacute;s derechos que se devengan en proporci&oacute;n al tiempo servido. Regir&aacute; la misma disposici&oacute;n si el contrato inicial ha tenido pr&oacute;rrogas, que en total incluido el primer per&iacute;odo no exceda de 60 d&iacute;as.<br /> &bull; La terminaci&oacute;n anticipada del contrato a plazo fijo, sin que exista causal justificada obliga al empleador a pagar la totalidad de los emolumentos convenidos hasta la fecha de t&eacute;rmino consignada en el contrato.<br /> (5) Ley N&deg;21.327, que agrega el art&iacute;culo 9 bis, que establece: &ldquo;En conformidad a lo dispuesto en el art&iacute;culo 515, el empleador deber&aacute; registrar en el sitio electr&oacute;nico de la Direcci&oacute;n del Trabajo los contratos de trabajo, dentro de los quince d&iacute;as siguientes a su celebraci&oacute;n.&rdquo;</p>\n  \n'),(3,'Tiempo Parcial',_binary '','2025-03-05 23:54:18','\n\n \n  \n \n  <center>\n  <p><strong>CONTRATO DE TRABAJO CON JORNADA PARCIAL (PART-TIME)</strong></p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>En la ciudad de [[CIUDAD]], a [[DIA]] del mes de [[MES]] de [[YEAR]], entre la Empresa [[RAZON_SOCIAL]], R.U.T. N&deg; [[RUT_EMPRESA]], representada por don(&ntilde;a) [[NOMBRE_ENCAEGADO]], RUT N&deg; [[RUT_ENCARGADO]]. en su calidad de [[CARGO_ENCARGADO]], ambos con domicilio para estos efectos en [[DIRECCION_ACUERDO]] , correo electr&oacute;nico [[CORREO_ENCARGADO]], en adelante \"el empleador\" y don (&ntilde;a) [[NOMBRE_TRABAJADOR]], R.U.T. N&deg; [[RUT_TRABAJADOR]], nacido (a) el [[FECHA_NACIMIENTOT]], de nacionalidad [[NACIONALIDAD]] , de profesi&oacute;n (u oficio) [[PROFESION]] de estado civil [[ESTADO_CIVIL]], domiciliado en [[DIRECCION_EMPLEADO]], correo electr&oacute;nico [[CORREO_EMPLEADO]], en adelante \"el/la trabajador(a)\", se ha convenido el siguiente contrato de trabajo.</p>\n  <p>&nbsp;</p>\n  <p>1&deg;.- El trabajador se compromete a desempe&ntilde;ar las labores de [[TAREA_ASIGNADA]]. En el recinto de la industria o establecimiento de propiedad del empleador, ubicado en calle [[DIRECCION_ACUERDO]] &nbsp;con los deberes y atribuciones que el empleador le asigne o a cualquier otro trabajo similar que se le encomiende.</p>\n  <p>&nbsp;</p>\n  <p>2&deg;.- El empleador podr&aacute; modificar por causa justificada, el recinto donde deben prestarse los servicios, con la &uacute;nica limitaci&oacute;n que el nuevo sitio quede dentro de la misma ciudad o localidad y esto no implique un menoscabo para el trabajador.</p>\n  <p>&nbsp;</p>\n  <p>3&deg;.- El trabajador en virtud del art&iacute;culo 40 del C&oacute;digo del Trabajo, cumplir&aacute; una jornada de trabajo ordinaria parcial de [[HORAS_SEMANALES]] &nbsp;horas semanales (no m&aacute;s de 30 horas) distribuidas de [[DIA_INICIO]] &nbsp;a [[DIA_TERMINO]] &nbsp;, de [[HORA_INICIO]] &nbsp;a [[HORA_TERMINO]] &nbsp;&nbsp;horas [[HORARIO_FINDESEMANA]] (las partes pueden pactar alternativas de distribuci&oacute;n de jornada, caso en que el empleador, con antelaci&oacute;n m&iacute;nima de 1 semana, est&aacute; facultado para determinar una de las alternativas pactadas, la que regir&aacute; en el per&iacute;odo siguiente).</p>\n  <p>&nbsp;</p>\n  <p>Las partes acuerdan las siguientes alternativas de distribuci&oacute;n de jornada, debiendo el empleador avisar por escrito al trabajador la jornada que se aplicar&aacute; con una anticipaci&oacute;n m&iacute;nima de una semana, respetando en todas ellas las [[HORAS_SEMANALES]] &nbsp;semanales:</p>\n  <p>&nbsp;</p>\n  <p>[[DESCRIPCIONHORARIOPARTTIME]]</p>\n  <p>&nbsp;</p>\n  <p>La jornada diaria de trabajo ser&aacute; interrumpida por un descanso de colaci&oacute;n de 60 minutos (m&aacute;xima de una hora).</p>\n  <p>&nbsp;</p>\n  <p>El trabajador se compromete a la vez, a cumplir la jornada de trabajo convenida</p>\n  <p>&nbsp;</p>\n  <p>en el presente contrato en su totalidad.</p>\n  <p>&nbsp;</p>\n  <p>4&deg;.- El empleador se compromete a remunerar los servicios del trabajador con un sueldo mensual de [[TIPO_PAGO]] que ser&aacute; liquidado y pagado por per&iacute;odo vencido en el lugar del trabajo.</p>\n  <p>&nbsp;</p>\n  <p>5&deg;.- El trabajador tendr&aacute; derecho a los siguientes beneficios, en proporci&oacute;n a los d&iacute;as efectivamente trabajados.</p>\n  <p>&nbsp;</p>\n  <p>[[BENEFICIOS]]</p>\n  <p>&nbsp;</p>\n  <p>6&deg;.- Las deducciones que el empleador podr&aacute; practicar a las remuneraciones del trabajador son las debidas a tiempo no trabajado por atrasos e inasistencias injustificadas y aquellas que autoriza el art. 58 del C&oacute;digo del Trabajo.</p>\n  <p>&nbsp;</p>\n  <p>7&deg;.- El trabajador se compromete y obliga expresamente a cumplir las instrucciones que le sean impartidas por el empleador por medio de jefes inmediatos o superiores, a cumplir su funciones con el debido cuidado y a respetar la normativa contenida en el Reglamento Interno de Orden, Higiene y Seguridad (cuando exista en la empresa), que declara conocer y que se considera parte integrante del presente contrato, recibiendo un ejemplar en este acto.</p>\n  <p>&nbsp;</p>\n  <p>8&deg; .- La duraci&oacute;n del presente contrato de trabajo ser&aacute; indefinida, pudiendo tener t&eacute;rmino por las causales establecidas en la legislaci&oacute;n vigente.</p>\n  <p>&nbsp;</p>\n  <p>9&deg; .- Se deja constancia que el trabajador ingres&oacute; al servicio del empleador el d&iacute;a [[FECHA_INICIO]].</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>10&deg;.- El contrato presente se firma en [[NEJEMPLARES]] ejemplares, declarando el trabajador haber recibido en este acto un ejemplar de &eacute;l, que es el fiel reflejo de la relaci&oacute;n laboral convenida.</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <table>\n  <tbody>\n  <tr>\n  <td width=\"312\">\n  <p>...........................................</p>\n  <p>FIRMA TRABAJADOR(A)</p>\n  <p>&nbsp;</p>\n  <p>RUT ...........................................</p>\n  </td>\n  <td width=\"312\">\n  <p>...........................................</p>\n  <p>FIRMA EMPLEADOR</p>\n  <p>&nbsp;</p>\n  <p>RUT ...........................................</p>\n  </td>\n  </tr>\n  </tbody>\n  </table>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>NOTA:</p>\n  <p>(1) Ley N&deg;21.327, de Modernizaci&oacute;n de la Direcci&oacute;n del Trabajo. Se agreg&oacute; en el numeral 2 del inciso primero del art&iacute;culo 10, del Contrato de Trabajo a continuaci&oacute;n de la palabra \"nacionalidad\", la siguiente frase: \", domicilio y direcci&oacute;n de correo electr&oacute;nico de ambas partes, si la tuvieren\".</p>\n  <p>(2) Art&iacute;culo 22, inciso 1&deg;, duraci&oacute;n de la jornada ordinaria de trabajo. Modificado por la Ley N&deg;21.561. A contar del 26.04.2024, la jornada de trabajo no exceder&aacute; de cuarenta y cuatro horas. Su distribuci&oacute;n se podr&aacute; efectuar en cada semana calendario o sobre la base de promedios semanales en lapsos de hasta cuatro semanas, en cuyo caso la jornada ordinaria no podr&aacute; exceder de cuarenta y cinco horas ordinarias en cada semana, ni extenderse con este l&iacute;mite por m&aacute;s de dos semanas.</p>\n  <p>(3) Modalidad alternativa de pago: de acuerdo con el inciso segundo del Art&iacute;culo 54 del C&oacute;digo del Trabajo, modificado por la Ley 21.327 &ldquo;A solicitud del trabajador(a), el pago podr&aacute; realizarse por medio de cheque, o vale vista bancario a su nombre, o transferencia electr&oacute;nica a la cuenta bancaria del trabajador, sin que ello importe costo alguno para &eacute;l.&nbsp; Ejemplo: El pago al trabajador/a, se realizar&aacute; mediante transferencia electr&oacute;nica a la siguiente cuenta:</p>\n  <p>Banco:[[BANCO]]</p>\n  <p>Tipo y n&uacute;mero de cuenta: [[TIPOCUENTA]]</p>\n  <p>Rut: [[RUT_TRABAJADOR]]</p>\n  <p>Correo electr&oacute;nico: [[CORREO_EMPLEADO]]</p>\n  <p>&nbsp;</p>\n  <p>(4) Este tipo de contrato se rige por las normas contempladas en el art. 159 N&ordm; 4 del C&oacute;digo del Trabajo, debiendo tenerse presente lo siguiente:</p>\n  <ul>\n  <li>La duraci&oacute;n del contrato de plazo, fijo, no podr&aacute; exceder de un a&ntilde;o, salvo que se tratare de gerentes o personas que tengan un t&iacute;tulo profesional o t&eacute;cnico, otorgado por instituciones de educaci&oacute;n superior del Estado o reconocido por &eacute;ste, caso en el cual la duraci&oacute;n no podr&aacute; exceder de dos a&ntilde;os.</li>\n  <li>La prestaci&oacute;n de servicios una vez expirado el plazo lo transforma en contrato de duraci&oacute;n indefinida.</li>\n  <li>Estos contratos s&oacute;lo admiten una renovaci&oacute;n. La segunda renovaci&oacute;n lo transforma en contrato de duraci&oacute;n indefinida.</li>\n  <li>La prestaci&oacute;n de servicios discontinuos durante 12 meses o m&aacute;s en un per&iacute;odo de quince meses hace presumir que hay contrato indefinido.</li>\n  <li>En los contratos que tengan una duraci&oacute;n de 30 d&iacute;as o menos, se entiende incluida en la remuneraci&oacute;n convenida el pago por feriado y dem&aacute;s derechos que se devengan en proporci&oacute;n al tiempo servido. Regir&aacute; la misma disposici&oacute;n si el contrato inicial ha tenido pr&oacute;rrogas, que en total incluido el primer per&iacute;odo no exceda de 60 d&iacute;as.</li>\n  <li>La terminaci&oacute;n anticipada del contrato a plazo fijo, sin que exista causal justificada obliga al empleador a pagar la totalidad de los emolumentos convenidos hasta la fecha de t&eacute;rmino consignada en el contrato.</li>\n  </ul>\n  <p>(5) Ley N&deg;21.327, que agrega el art&iacute;culo 9 bis, que establece: &ldquo;En conformidad a lo dispuesto en el art&iacute;culo 515, el empleador deber&aacute; registrar en el sitio electr&oacute;nico de la Direcci&oacute;n del Trabajo los contratos de trabajo, dentro de los quince d&iacute;as siguientes a su celebraci&oacute;n.&rdquo;</p>\n  </center>\n  \n'),(4,'Temporada',_binary '','2025-03-05 23:54:18','\n\n \n  <p style=\"text-align: center;\"><strong>CONTRATO DE TRABAJO DE TEMPORADA</strong></p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>En la ciudad de [[CIUDAD]], a [[DIA]] del mes de [[MES]] de [[YEAR]], entre la Empresa [[RAZON_SOCIAL]], R.U.T. N&deg; [[RUT_EMPRESA]], representada por don(&ntilde;a) [[NOMBRE_ENCAEGADO]], RUT N&deg; [[RUT_ENCARGADO]], en su calidad de [[CARGO_ENCARGADO]], ambos con domicilio para estos efectos en [[DIRECCION_ACUERDO]], correo electr&oacute;nico [[CORREO_ENCARGADO]], en adelante \"el empleador\" y don (&ntilde;a) [[NOMBRE_TRABAJADOR]], R.U.T. N&deg; [[RUT_TRABAJADOR]], nacido (a) el [[FECHA_NACIMIENTOT]], de nacionalidad [[NACIONALIDAD]], de profesi&oacute;n (u oficio) [[PROFESION]], de estado civil [[ESTADO_CIVIL]], domiciliado en [[DIRECCION_EMPLEADO]], correo electr&oacute;nico [[CORREO_EMPLEADO]], que en adelante se denominar&aacute; &ldquo;el trabajador\", se ha convenido en el siguiente contrato de trabajo de temporada o de faena transitoria.</p>\n  <p>&nbsp;</p>\n  <p><strong>PRIMERO. -</strong> El trabajador prestar&aacute; sus servicios como............................................................... en las siguientes faenas ........................ de temporada .................................... ubicadas en&hellip;&hellip;&hellip;&hellip;&hellip;..&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>\n  <p>&nbsp;</p>\n  <p><strong>SEGUNDO. -</strong> El presente contrato se entender&aacute; terminado autom&aacute;ticamente, en la fecha en que concluyen las faenas que le dieron origen y a que se ha hecho referencia en la cl&aacute;usula primera, sin perjuicio que el empleador comunique por escrito este hecho, de conformidad con lo dispuesto en el art&iacute;culo 162 del C&oacute;digo del Trabajo.</p>\n  <p>&nbsp;</p>\n  <p><strong>TERCERO. -</strong> &nbsp;La jornada de trabajo ser&aacute; de [[HORAS_SEMANALES]] semanales distribuidas de [[DIA_INICIO]] a [[DIA_TERMINO]], de [[HORA_INICIO]] a [[HORA_TERMINO]] horas [[HORARIO_FINDESEMANA]] y accediendo a 1 hora de colaci&oacute;n en la semana. El tiempo de 1 hora para colaci&oacute;n ser&aacute; de cargo del/la trabajadora.</p>\n  <p>&nbsp;</p>\n  <p><strong>CUARTO. -</strong> &nbsp;El empleador se compromete a remunerar los servicios del/la trabajador(a) con un sueldo mensual se calculara de la siguiente manera [[TIPO_PAGO]] que ser&aacute; liquidado y pagado, por per&iacute;odos vencidos en forma proporcional a los d&iacute;as efectivamente trabajados. El pago de la remuneraci&oacute;n, se har&aacute; en dinero efectivo. <strong>(3)</strong></p>\n  <p>&nbsp;</p>\n  <p><strong>QUINTO:</strong> El empleador se compromete a otorgar o suministrar al trabajador las condiciones higi&eacute;nicas y adecuadas de alojamiento de acuerdo a la zona, condiciones clim&aacute;ticas y dem&aacute;s propias de la faena de temporada que se trate, especialmente en el alojamiento y preparaci&oacute;n y consumo de alimentos, sin perjuicio de lo anterior, se obliga a entregar los siguientes beneficios ..................................... (Casa habitaci&oacute;n, luz, combustible, alimentos u otras especies o servicios).</p>\n  <p>En el caso que, por la distancia o las dificultades de transporte no sea posible a los trabajadores adquirir sus alimentos, el empleador deber&aacute;, adem&aacute;s, proporcion&aacute;rselos.</p>\n  <p>En el caso que entre la ubicaci&oacute;n de las faenas y el lugar donde el trabajador aloje o pueda alojar, medie una distancia igual o superior a tres kil&oacute;metros y no existiesen medios de transporte p&uacute;blico, el empleador deber&aacute; proporcionar entre ambos puntos los medios de movilizaci&oacute;n necesarios, que re&uacute;nan los requisitos de seguridad que determine el reglamento.</p>\n  <p>&nbsp;</p>\n  <p><strong>SEXTO. -</strong> &nbsp;Cuando por necesidades de funcionamiento de la Empresa, sea necesario pactar trabajo en tiempo extraordinario, el trabajador(a) que lo acuerde, se obligar&aacute; a cumplir el horario que al efecto determinen con el/la empleador/a, dentro de los l&iacute;mites legales. Dicho acuerdo constar&aacute; por escrito y se firmar&aacute; por ambas partes, previamente a la realizaci&oacute;n del trabajo. . Con todo, las partes podr&aacute;n acordar por escrito que las horas extraordinarias se compensen por d&iacute;as adicionales de feriado.(4)</p>\n  <p>&nbsp;</p>\n  <p><strong>OCTAVO. -</strong> Queda prohibido expresamente al trabajador(a) laborar sobretiempo o simplemente permanecer en el recinto de la Empresa, despu&eacute;s de la hora diaria de salida, salvo en los casos a que se refiere el inciso precedente.</p>\n  <p>&nbsp;</p>\n  <p><strong>NOVENO. -</strong> De acuerdo al art&iacute;culo 38, N&ordm; 3 del C&oacute;digo del Trabajo, las partes dejan establecido que la jornada ordinaria puede comprender domingos o festivos, atendido el car&aacute;cter de las labores agr&iacute;colas materia del presente contrato.</p>\n  <p>&nbsp;</p>\n  <p><strong>DECIMO. &ndash;</strong> El/La trabajador(a) declara que su r&eacute;gimen previsional es el siguiente:</p>\n  <p>REGIMEN DE PENSIONES: [[AFP]]</p>\n  <p>REGIMEN DE SALUD: [[SALUD]]</p>\n  <p>&nbsp;</p>\n  <p><strong>DECIMO SEGUNDO. - </strong>Se deja constancia que el trabajador ingres&oacute; al servicio del empleador el [[FECHA_INICIO]].</p>\n  <p><strong>&nbsp;</strong></p>\n  <p><strong>DECIMO TERCERO. -</strong> Para todos los efectos derivados del presente contrato las partes fijan domicilio en la ciudad de Rancagua y se someten a la jurisdicci&oacute;n de sus Tribunales.</p>\n  <p>&nbsp;</p>\n  <p><strong>DECIMO CUARTO. -</strong> El presente contrato se firma en [[NEJEMPLARES]] ejemplares, declarando el/la trabajador(a) haber recibido en este acto un ejemplar de dicho instrumento, que es el fiel reflejo de la relaci&oacute;n laboral convenida.</p>\n  <p>El empleador se obliga a mantener en el lugar de trabajo un ejemplar firmado de este contrato, asimismo, deber&aacute; registrar este contrato en el sitio web de la Direcci&oacute;n del Trabajo (www.direcciondeltrabajo.cl).&nbsp; <strong>(5)</strong></p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <table>\n  <tbody>\n  <tr>\n  <td width=\"312\">\n  <p>............................................</p>\n  <p>FIRMA EMPLEADOR</p>\n  <p>&nbsp;</p>\n  <p>RUT ............................................</p>\n  </td>\n  <td width=\"312\">\n  <p>............................................</p>\n  <p>FIRMA TRABAJADOR/A</p>\n  <p>&nbsp;</p>\n  <p>RUT ............................................</p>\n  </td>\n  </tr>\n  </tbody>\n  </table>\n  <p>&nbsp;</p>\n  <p>&nbsp;</p>\n  <p>(1) Se agrega en consideraci&oacute;n a la reforma introducida por la Ley n&deg;21.327, que complemento el art&iacute;culo 10 n&deg;2 en la cual dispone: <em>Agregase en el numeral 2 del inciso primero del art&iacute;culo 10, a continuaci&oacute;n de la palabra \"nacionalidad\", la siguiente frase: \", domicilio y direcci&oacute;n de correo electr&oacute;nico de ambas partes, si la tuvieren\".</em></p>\n  <p>(2) Art&iacute;culo 22, inciso 1&deg;, duraci&oacute;n de la jornada ordinaria de trabajo. Modificado por la Ley N&deg;21.561. La jornada no exceder&aacute; de cuarenta y cuatro horas semanales. Su distribuci&oacute;n se podr&aacute; efectuar en cada semana calendario o sobre la base de promedios semanales en lapsos de hasta cuatro semanas, en cuyo caso la jornada ordinaria no podr&aacute; exceder de cuarenta y cinco horas ordinarias en cada semana, ni extenderse con este l&iacute;mite por m&aacute;s de dos semanas</p>\n  <p>(3) Modalidad alternativa de pago: de acuerdo con el inciso segundo del Art&iacute;culo 54 del C&oacute;digo del Trabajo, modificado por la Ley 21.327 &ldquo;A solicitud del trabajador(a), el pago podr&aacute; realizarse por medio de cheque, o vale vista bancario a su nombre, o transferencia electr&oacute;nica a la cuenta bancaria del trabajador, sin que ello importe costo alguno para &eacute;l.&nbsp; Ejemplo: El pago al trabajador/a, se realizar&aacute; mediante transferencia electr&oacute;nica a la siguiente cuenta:</p>\n  <p>Banco: [[BANCO]]</p>\n  <p>Tipo y n&uacute;mero de cuenta: [[TIPOCUENTA]]</p>\n  <p>Rut: [[RUT_TRABAJADOR]]</p>\n  <p>Correo electr&oacute;nico: [[CORREO_EMPLEADO]]</p>\n  <p>&nbsp;</p>\n  <p>(4) Art&iacute;culo 32, inciso 4&deg; del C&oacute;digo del Trabajo, modificaci&oacute;n introducida por la Ley N&deg;21.561, de 26.04.2024.</p>\n  <p>&nbsp;</p>\n  <p>(5) La Ley N&deg;21.327 agrega el art&iacute;culo 9 bis que establece: &ldquo;En conformidad a lo dispuesto en el art&iacute;culo 515, el empleador deber&aacute; registrar en el sitio electr&oacute;nico de la Direcci&oacute;n del Trabajo los contratos de trabajo, dentro de los quince d&iacute;as siguientes a su celebraci&oacute;n.&rdquo;</p>\n  \n'),(5,'Obra o Faena',_binary '','2025-03-05 23:54:18','\n\n <center>\n <p>CONTRATO DE TRABAJO POR OBRA LABOR</p>\n <p>&nbsp;</p>\n <p>CONTRATO DE TRABAJO DE DURACION POR LA OBRA O LABOR CONTRATADA.</p>\n <p>&nbsp;</p>\n <p>En la ciudad de [[CIUDAD]], a [[DIA]] del mes de [[MES]] de [[YEAR]], entre la Empresa [[RAZON_SOCIAL]], R.U.T. N&deg; [[RUT_EMPRESA]], representada por don(&ntilde;a) [[NOMBRE_ENCAEGADO]], RUT N&deg; [[RUT_ENCARGADO]], en su calidad de [[CARGO_ENCARGADO]], ambos con domicilio para estos efectos en [[DIRECCION_ACUERDO]], correo electr&oacute;nico [[CORREO_ENCARGADO]], en adelante \"el empleador\" y don (&ntilde;a) [[NOMBRE_TRABAJADOR]], R.U.T. N&deg; [[RUT_TRABAJADOR]], nacido (a) el [[FECHA_NACIMIENTOT]], de nacionalidad [[NACIONALIDAD]], de profesi&oacute;n (u oficio) [[PROFESION]], de estado civil [[ESTADO_CIVIL]], domiciliado en [[DIRECCION_EMPLEADO]], correo electr&oacute;nico [[CORREO_EMPLEADO]], en adelante \"el/la trabajador(a)\", se ha convenido el siguiente contrato de trabajo.</p>\n <p>Entre el empleador y el trabajador, de las condiciones ya dichas identificados como aparece al pie de sus correspondientes firmas se ha celebrado el presente contrato individual de&nbsp; trabajo, regido adem&aacute;s por las siguientes cl&aacute;usulas:</p>\n <p>&nbsp;</p>\n <p><strong>Primera.</strong> El/La trabajador(a) se compromete y obliga a ejecutar el trabajo de [[TAREA_ASIGNADA]] que se le encomienda. Los servicios se prestar&aacute;n en sitios o propiedades donde el empleador tenga acuerdos, sin perjuicio de la facultad del empleador de alterar, por causa justificada, la naturaleza de los servicios, o el sitio o recinto en que ellos han de prestarse, con la sola limitaci&oacute;n de que se trate de labores similares y que el nuevo sitio o recinto quede dentro de la misma localidad o ciudad, conforme a lo se&ntilde;alado en el art&iacute;culo 12&ordm; del C&oacute;digo del Trabajo.</p>\n <p>&nbsp;</p>\n <p><strong>Segunda. </strong>El empleador pagar&aacute; al trabajador por la prestaci&oacute;n de sus servicios el salario indicado, [[TIPO_PAGO]]. Dentro de este pago se encuentra incluida la remuneraci&oacute;n de los descansos dominicales y festivos de que tratan los cap&iacute;tulos I y II del t&iacute;tulo VII del C&oacute;digo Sustantivo del Trabajo. Se aclara y se conviene que en los casos en los que el trabajador devengue comisiones o cualquier otra modalidad de salario variable, el 82.5% de dichos ingresos, constituye remuneraci&oacute;n ordinaria y el 17.5% restante esta designado a remunerar el descanso en los d&iacute;as dominicales y festivos que tratan los cap&iacute;tulos I y II del t&iacute;tulo VII del C&oacute;digo Sustantivo de Trabajo.</p>\n <p>&nbsp;</p>\n <p><strong>Tercera. </strong>Todo trabajo suplementario o en horas extras y todo trabajo en d&iacute;a domingo&nbsp; o festivo en los que legalmente debe concederse el descanso, se remunerar&aacute;&nbsp; conforme a la Ley, as&iacute; como los correspondientes recargos nocturnos. Para el reconocimiento y pago del trabajo suplementario, dominical o festivo el empleador o sus representantes deben autorizarlo previamente por escrito. Cuando la necesidad de este trabajo se presente de manera imprevista o inaplazable, deber&aacute; ejecutarse y darse cuenta de &eacute;l por escrito, a la mayor brevedad, al empleador o sus representantes. El empleador, en consecuencia, no reconocer&aacute; ning&uacute;n trabajo suplementario o en d&iacute;as de descanso legalmente obligatorio que no haya sido autorizado previamente&nbsp; o avisado inmediatamente, como queda dicho.</p>\n <p>&nbsp;</p>\n <p><strong>Cuarta.</strong> La jornada de trabajo ser&aacute; de [[HORAS_SEMANALES]] semanales distribuidas de [[DIA_INICIO]] a [[DIA_TERMINO]], de [[HORA_INICIO]] a [[HORA_TERMINO]] horas [[HORARIO_FINDESEMANA]] y accediendo a 1 hora de colaci&oacute;n en la semana. El tiempo de 1 hora para colaci&oacute;n ser&aacute; de cargo del/la trabajadora.</p>\n <p>&nbsp;</p>\n <p><strong>Quinta.</strong> El presente contrato se celebra por el tiempo que dure la realizaci&oacute;n de la obra (o labor contratada), seg&uacute;n se determino anteriormente.</p>\n <p>&nbsp;</p>\n <p><strong>Sexta. </strong>Son justas causas para dar por terminado unilateralmente este contrato por cualquiera de las partes, las enumeradas en el art&iacute;culo 7&ordm; del decreto 2351 de 1965; y, adem&aacute;s, por parte del empleado, las faltas que para el efecto se califiquen como graves en el espacio reservado para las cl&aacute;usulas adicionales en el presente contrato.</p>\n <p>&nbsp;</p>\n <p><strong>S&eacute;ptima. </strong>Las invenciones o descubrimientos realizados por el trabajador contratado&nbsp; para investigar pertenecen al empleador, de conformidad con el art&iacute;culo 539 del C&oacute;digo de Comercio, as&iacute; como el art&iacute;culo 20 y concordantes de la ley 23 de 1982 sobre derechos de autor. En cualquier otro caso el invento pertenece al trabajador, salvo cuando &eacute;ste no haya sido contratado para investigar y realice la invenci&oacute;n mediante datos o medios conocidos o utilizados en raz&oacute;n de la labor desempe&ntilde;ada, evento en el cual el trabajador, tendr&aacute; derecho a una compensaci&oacute;n que se fijar&aacute; d&eacute; acuerdo con el monto del salario, la importancia del invento o descubrimiento, el beneficio que reporte al empleador u otros factores similares.</p>\n <p>&nbsp;</p>\n <p><strong>Octava. </strong>Las partes podr&aacute;n convenir&nbsp; que el trabajo se preste en lugar distinto al inicialmente contratado, siempre que tales traslados no desmejoren las condiciones laborales o de remuneraci&oacute;n del trabajador, o impliquen perjuicios para &eacute;l. Los gastos que se originen con el traslado ser&aacute;n cubiertos por el empleador de conformidad con el numeral 8&ordm; del art&iacute;culo 57 del C&oacute;digo Sustantivo del Trabajo. El trabajador se obliga a aceptar los cambios de oficio que decida el empleador dentro de su poder subordinante, siempre que se respeten las condiciones laborales del trabajador&nbsp; y no se le causen perjuicios. Todo ello sin que se afecte el honor, la dignidad y los derechos m&iacute;nimos del trabajador, de conformidad con el art&iacute;culo 23 del C&oacute;digo Sustantivo del&nbsp; Trabajo, modificado por el art&iacute;culo 1&ordm; de la Ley 50 de 1990.</p>\n <p>&nbsp;</p>\n <p><strong>Novena.</strong> Este contrato ha sido redactado estrictamente de acuerdo con la ley y la jurisprudencia y ser&aacute; interpretado de buena fe y en consonancia con el C&oacute;digo Sustantivo del Trabajo&nbsp; cuyo objeto, definido en su art&iacute;culo 1&ordm;, es lograr la justicia en las relaciones entre empleadores y trabajadores dentro de un esp&iacute;ritu de coordinaci&oacute;n econ&oacute;mica y equilibrio social.</p>\n <p>&nbsp;</p>\n <p><strong>D&eacute;cima.</strong> El presente contrato reemplaza en su integridad y deja sin efecto alguno cualquiera otro contrato verbal o escrito celebrado por las partes con anterioridad. Las modificaciones que se acuerden al presente contrato se anotar&aacute;n a continuaci&oacute;n de su texto.</p>\n <p>&nbsp;</p>\n <p><strong>UNDECIMO. -</strong> Para todos los efectos derivados del presente contrato las partes fijan domicilio en la ciudad de Rancagua y se someten a la Jurisdicci&oacute;n de sus Tribunales.</p>\n <p>&nbsp;</p>\n <p>&nbsp;</p>\n <p>&nbsp;</p>\n <table>\n <tbody>\n <tr>\n <td width=\"312\">\n <p>...........................................</p>\n <p>FIRMA TRABAJADOR(A)</p>\n <p>&nbsp;</p>\n <p>RUT ...........................................</p>\n </td>\n <td width=\"312\">\n <p>...........................................</p>\n <p>FIRMA EMPLEADOR</p>\n <p>&nbsp;</p>\n <p>RUT ...........................................</p>\n </td>\n </tr>\n </tbody>\n </table>\n <p>&nbsp;</p>\n <p>&nbsp;</p>\n <p>NOTA:</p>\n <p>(1) Ley N&deg;21.327, de Modernizaci&oacute;n de la Direcci&oacute;n del Trabajo. Se agreg&oacute; en el numeral 2 del inciso primero del art&iacute;culo 10, del Contrato de Trabajo a continuaci&oacute;n de la palabra \"nacionalidad\", la siguiente frase: \", domicilio y direcci&oacute;n de correo electr&oacute;nico de ambas partes, si la tuvieren\".</p>\n <p>(2) Art&iacute;culo 22, inciso 1&deg;, duraci&oacute;n de la jornada ordinaria de trabajo. Modificado por la Ley N&deg;21.561. A contar del 26.04.2024, la jornada de trabajo no exceder&aacute; de cuarenta y cuatro horas. Su distribuci&oacute;n se podr&aacute; efectuar en cada semana calendario o sobre la base de promedios semanales en lapsos de hasta cuatro semanas, en cuyo caso la jornada ordinaria no podr&aacute; exceder de cuarenta y cinco horas ordinarias en cada semana, ni extenderse con este l&iacute;mite por m&aacute;s de dos semanas.</p>\n <p>(3) Modalidad alternativa de pago: de acuerdo con el inciso segundo del Art&iacute;culo 54 del C&oacute;digo del Trabajo, modificado por la Ley 21.327 &ldquo;A solicitud del trabajador(a), el pago podr&aacute; realizarse por medio de cheque, o vale vista bancario a su nombre, o transferencia electr&oacute;nica a la cuenta bancaria del trabajador, sin que ello importe costo alguno para &eacute;l. Ejemplo: El pago al trabajador/a, se realizar&aacute; mediante transferencia electr&oacute;nica a la siguiente cuenta:</p>\n <p>Banco:[[BANCO]]</p>\n <p>Tipo y n&uacute;mero de cuenta: [[TIPOCUENTA]]</p>\n <p>Rut: [[RUT_TRABAJADOR]]</p>\n <p>Correo electr&oacute;nico: [[CORREO_EMPLEADO]]</p>\n <p>(4) Este tipo de contrato se rige por las normas contempladas en el art. 159 N&ordm; 4 del C&oacute;digo del Trabajo, debiendo tenerse presente lo siguiente:</p>\n <ul>\n <li>La duraci&oacute;n del contrato de plazo, fijo, no podr&aacute; exceder de un a&ntilde;o, salvo que se tratare de gerentes o personas que tengan un t&iacute;tulo profesional o t&eacute;cnico, otorgado por instituciones de educaci&oacute;n superior del Estado o reconocido por &eacute;ste, caso en el cual la duraci&oacute;n no podr&aacute; exceder de dos a&ntilde;os.</li>\n <li>La prestaci&oacute;n de servicios una vez expirado el plazo lo transforma en contrato de duraci&oacute;n indefinida.</li>\n <li>Estos contratos s&oacute;lo admiten una renovaci&oacute;n. La segunda renovaci&oacute;n lo transforma en contrato de duraci&oacute;n indefinida.</li>\n <li>La prestaci&oacute;n de servicios discontinuos durante 12 meses o m&aacute;s en un per&iacute;odo de quince meses hace presumir que hay contrato indefinido.</li>\n <li>En los contratos que tengan una duraci&oacute;n de 30 d&iacute;as o menos, se entiende incluida en la remuneraci&oacute;n convenida el pago por feriado y dem&aacute;s derechos que se devengan en proporci&oacute;n al tiempo servido. Regir&aacute; la misma disposici&oacute;n si el contrato inicial ha tenido pr&oacute;rrogas, que en total incluido el primer per&iacute;odo no exceda de 60 d&iacute;as.</li>\n <li>La terminaci&oacute;n anticipada del contrato a plazo fijo, sin que exista causal justificada obliga al empleador a pagar la totalidad de los emolumentos convenidos hasta la fecha de t&eacute;rmino consignada en el contrato.</li>\n </ul>\n <p>(5) Ley N&deg;21.327, que agrega el art&iacute;culo 9 bis, que establece: &ldquo;En conformidad a lo dispuesto en el art&iacute;culo 515, el empleador deber&aacute; registrar en el sitio electr&oacute;nico de la Direcci&oacute;n del Trabajo los contratos de trabajo, dentro de los quince d&iacute;as siguientes a su celebraci&oacute;n.&rdquo;</p>\n </center>');
/*!40000 ALTER TABLE `tipocontratos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipofiniquito`
--

DROP TABLE IF EXISTS `tipofiniquito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipofiniquito` (
  `idTipoFiniquito` int NOT NULL AUTO_INCREMENT,
  `Articulo` int DEFAULT NULL,
  `Numero` int DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `FechaCreacion` datetime DEFAULT NULL,
  PRIMARY KEY (`idTipoFiniquito`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipofiniquito`
--

LOCK TABLES `tipofiniquito` WRITE;
/*!40000 ALTER TABLE `tipofiniquito` DISABLE KEYS */;
INSERT INTO `tipofiniquito` VALUES (8,159,1,'Renuncia Voluntaria','2025-04-02 18:00:44'),(9,159,2,'Mutuo Acuerdo','2025-04-02 18:00:44'),(10,160,3,'Despido con justa causa','2025-04-02 18:00:44'),(11,161,3,'Despido sin justa causa','2025-04-02 18:00:44'),(12,159,4,'T√©rmino de Contrato a Plazo','2025-04-02 18:00:44'),(13,159,5,'Muerte del Trabajador','2025-04-02 18:00:44'),(14,159,6,'Fuerza Mayor o Caso Fortuito','2025-04-02 18:00:44'),(15,159,7,'Vencimiento de Obra o Faena','2025-04-02 18:00:44');
/*!40000 ALTER TABLE `tipofiniquito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipopago`
--

DROP TABLE IF EXISTS `tipopago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipopago` (
  `IdTipoPago` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) NOT NULL,
  `Fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `Estado` bit(1) DEFAULT b'1',
  PRIMARY KEY (`IdTipoPago`),
  UNIQUE KEY `Descripcion` (`Descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipopago`
--

LOCK TABLES `tipopago` WRITE;
/*!40000 ALTER TABLE `tipopago` DISABLE KEYS */;
INSERT INTO `tipopago` VALUES (1,'Por Hora','2025-03-03 23:23:17',_binary ''),(2,'Por Tarea','2025-03-03 23:23:17',_binary ''),(3,'Diario','2025-03-03 23:23:17',_binary ''),(4,'Sueldo Base','2025-03-03 23:23:17',_binary ''),(5,'Trato','2025-03-03 23:23:17',_binary '');
/*!40000 ALTER TABLE `tipopago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `IdUsuario` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(50) NOT NULL,
  `Contrase√±a` varchar(255) NOT NULL,
  `IdRol` int NOT NULL,
  `IdEmpresa` int NOT NULL,
  `FechaCreacion` datetime DEFAULT CURRENT_TIMESTAMP,
  `Estado` bit(1) DEFAULT b'1',
  `Nombres` varchar(45) DEFAULT NULL,
  `Apellidos` varchar(45) DEFAULT NULL,
  `Rut` varchar(12) DEFAULT NULL,
  `Correo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdUsuario`),
  UNIQUE KEY `NombreUsuario` (`NombreUsuario`),
  KEY `fk_usuarios_roles` (`IdRol`),
  KEY `fk_usuarios_empresas` (`IdEmpresa`),
  CONSTRAINT `fk_usuarios_empresas` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`),
  CONSTRAINT `fk_usuarios_roles` FOREIGN KEY (`IdRol`) REFERENCES `roles` (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin1','123456',1,1,'2025-03-03 23:30:44',_binary '','Jose','Vergara','19.850.956-6','jose.vergara@gmail.com'),(2,'javiLuna','$2a$10$.GzPUCkX3SbKmSyvQ/pDhuorDOffwGJJz2a/QkXSqeEiuh3Vydj8.',1,3,'2025-03-03 23:30:44',_binary '','Javiera','Rivera','19254364-9','javiera.rivera@gmail.com'),(3,'javiluna22','$2a$10$HNZuq/YuttGOy0WZHfDlIOitvhX9nMEs6tJV0s96FFgHfEARnXG9a',1,3,'2025-03-29 13:46:55',_binary '\0','fulanos','fulanitos','22222222-2','fulano@gmail.com');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vacaciones`
--

DROP TABLE IF EXISTS `vacaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vacaciones` (
  `idVacaciones` int NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int NOT NULL,
  `FechaIni` date NOT NULL,
  `FechaFin` date NOT NULL,
  `CantDias` int NOT NULL,
  `SaldoTrabajador` int NOT NULL,
  `FechaRegistro` datetime NOT NULL,
  `Usuario` int DEFAULT NULL,
  `IdEmpresa` int NOT NULL,
  `Fecha_Retorno` datetime DEFAULT NULL,
  PRIMARY KEY (`idVacaciones`),
  KEY `FK_Vacacion_Empleado_idx` (`IdEmpleado`),
  KEY `FK_Vacacion_Empresa_idx` (`IdEmpresa`),
  CONSTRAINT `FK_Vacacion_Empleado` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`),
  CONSTRAINT `FK_Vacacion_Empresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresas` (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacaciones`
--

LOCK TABLES `vacaciones` WRITE;
/*!40000 ALTER TABLE `vacaciones` DISABLE KEYS */;
INSERT INTO `vacaciones` VALUES (4,4,'2025-03-29','2025-04-04',4,15,'2025-03-29 00:07:08',2,3,'2025-04-07 00:00:00');
/*!40000 ALTER TABLE `vacaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `valorescargas`
--

DROP TABLE IF EXISTS `valorescargas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `valorescargas` (
  `idValoresCargas` int NOT NULL AUTO_INCREMENT,
  `ValorHijos` decimal(18,2) DEFAULT NULL,
  `ValorConyuge` decimal(18,2) DEFAULT NULL,
  `ValorDiscapacidad` decimal(18,2) DEFAULT NULL,
  `Tope` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`idValoresCargas`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `valorescargas`
--

LOCK TABLES `valorescargas` WRITE;
/*!40000 ALTER TABLE `valorescargas` DISABLE KEYS */;
INSERT INTO `valorescargas` VALUES (1,21243.00,21243.00,42486.00,598698.00),(2,13036.00,13036.00,26072.00,874460.00),(3,4119.00,4119.00,8238.00,1363858.00);
/*!40000 ALTER TABLE `valorescargas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'dbpeopleflow'
--
/*!50003 DROP PROCEDURE IF EXISTS `DeleteAnexosContratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteAnexosContratos`(
    IN p_IdAnexo INT,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT

        delete from anexocontrato where idAnexoContrato=p_IdAnexo;
        
        CALL RegistroHistorial(p_IdUsuario,'delete','anexocontrato',p_IdAnexo);

		select * from anexocontrato where idAnexoContrato=p_IdAnexo;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeleteArchivosEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteArchivosEmpresa`(
    IN p_IdArchivo INT,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT

        delete from ArchivosEmpresa where idArchivos=p_IdArchivo;
        
        CALL RegistroHistorial(p_IdUsuario,'delete','ArchivosEmpresa',p_IdArchivo);


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeleteCargasByTrabajador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteCargasByTrabajador`(in p_IdTrabajador int)
BEGIN
    delete from cargasempleados  where IdEmpleado = p_IdTrabajador;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EliminarVacaciones` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarVacaciones`(in p_IdVacaciones int)
BEGIN
    delete from vacaciones
    where idVacaciones = p_IdVacaciones;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Getafp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Getafp`()
BEGIN
    SELECT * FROM afp;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetAFPById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAFPById`(
    IN p_IdAFP INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
	select * from afp where idAFP=p_IdAFP;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetAnexosContratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAnexosContratos`(IN IdContrato INT)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select * from anexocontrato where IdContrato=IdContrato;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetArchivosEmpresas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetArchivosEmpresas`(IN p_IdEmpresa INT)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select * from ArchivosEmpresa where IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetAsistenciaSemanalEmpleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAsistenciaSemanalEmpleado`(
    IN p_IdEmpresa INT
)
BEGIN
    SELECT 
    e.IdEmpleado,
    CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
    YEARWEEK(tea.FechaAsignacion) AS Semana,  -- Agrupar por semana
    j.HorasSemanales AS HorasContratadas,
    SUM(
        (TIME_TO_SEC(tea.HoraTermino) - TIME_TO_SEC(tea.HoraInicio)) / 3600
    ) AS HorasTrabajadas
	FROM tareasempleadosasistencia tea
	INNER JOIN tareas t ON tea.IdTarea = t.IdTarea
	INNER JOIN empleados e ON tea.IdEmpleado = e.IdEmpleado
	INNER JOIN jornadas j ON t.IdJornada = j.IdJornadas
	WHERE t.IdTipoPago IN (3, 4) 
	AND j.IdEmpresa = p_IdEmpresa  -- Filtrar por empresa
	AND tea.HoraInicio IS NOT NULL
	AND tea.HoraTermino IS NOT NULL
	GROUP BY e.IdEmpleado, Semana, j.HorasSemanales
	ORDER BY Semana, Empleado;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetAsistenciasNoPagada` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAsistenciasNoPagada`(
    IN p_IdEmpleado INT,
    IN p_MES INT
)
BEGIN
    SELECT  
        *
    FROM 
        tareasempleadosasistencia 
    WHERE 
        IdEmpleado = p_IdEmpleado 
        AND MONTH(FechaAsignacion) = p_MES
    ORDER BY 
        FechaAsignacion DESC ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetBonificacionByEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetBonificacionByEmpresa`(in p_IdEmpresa int)
BEGIN
    Select b.*,t.Titulo as Tarea from bonificaciones b
    left join Tareas t on t.IdTarea=b.IdTarea
    where b.IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetBonificacionEmpleados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetBonificacionEmpleados`(
    IN p_IdBonificacion INT
)
BEGIN

    -- Retornar la Bonificaci√≥n completa con la descripci√≥n de los empleados
    SELECT 
        b.IdEmpleado as ID, 
        CONCAT(e.Nombre, ' ', e.Apellido, ' / ', e.Rut) AS Descripcion
    FROM 
        bonificacionesempleados b
	JOIN bonificaciones bo ON bo.IdBonificacion=b.IdBonificacion
    JOIN empleados e ON b.IdEmpleado = e.IdEmpleado
    WHERE b.IdBonificacion = p_IdBonificacion and bo.Estado=1;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetBonificacionesEmpleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetBonificacionesEmpleado`(
    IN p_IdEmpleado INT,
    IN p_IdEmpresa INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    SELECT 
        b.IdBonificacion, 
        b.Descripcion, 
        b.Monto, 
        b.FechaAplicacion,
        'General (para todos)' AS TipoBonificacion,
        b.Imponible
    FROM bonificaciones b
    WHERE b.IdEmpresa = p_IdEmpresa and b.Estado = 1
    AND NOT EXISTS (
        SELECT 1 
        FROM bonificacionesempleados be 
        WHERE be.IdBonificacion = b.IdBonificacion
    )
    UNION 
    -- Obtener bonificaciones asignadas espec√≠ficamente al empleado dentro de la empresa
    SELECT 
        b.IdBonificacion, 
        b.Descripcion, 
        b.Monto, 
        b.FechaAplicacion,
        'Asignada al empleado' AS TipoBonificacion,
        b.Imponible
    FROM bonificaciones b
    INNER JOIN bonificacionesempleados be 
        ON b.IdBonificacion = be.IdBonificacion
    WHERE be.IdEmpleado = p_IdEmpleado and b.Estado = 1
    AND b.IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetCargasByTrabajador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCargasByTrabajador`(in p_IdTrabajador int)
BEGIN
    select * from cargasempleados  where IdEmpleado = p_IdTrabajador;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetContratoByTrabajador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetContratoByTrabajador`(in p_IdTrabajador int)
BEGIN
    SELECT c.*,e.Rut,e.Nombre,e.Apellido,r.Descripcion as Cargo, t.Descripcion as TipoContrato, p.Descripcion as Plazo FROM contratos c
    inner join empleados e on e.IdEmpleado=c.IdEmpleado
    inner join roles r on r.IdRol=e.IdRol
    inner join tipocontratos t on t.IdTipoContrato=c.IdTipoContrato
    left join plazos p on p.IdPlazo = c.IdPlazo
    where e.IdEmpleado=p_IdTrabajador and c.Estado = 1 and (NOW() BETWEEN FechaInicio and FechaFin or t.IdTipoContrato in (2,3,4,5));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetContratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetContratos`(IN p_IdEmpresa INT)
BEGIN
    SELECT c.*,e.Rut,e.Nombre,e.Apellido,r.Descripcion as Cargo, t.Descripcion as TipoContrato, p.Descripcion as Plazo, ta.Titulo as Tarea FROM contratos c
    inner join empleados e on e.IdEmpleado=c.IdEmpleado
    inner join roles r on r.IdRol=e.IdRol
    inner join tipocontratos t on t.IdTipoContrato=c.IdTipoContrato
    inner join tareas ta on ta.IdTarea=c.IdTarea
    left join plazos p on p.IdPlazo = c.IdPlazo
    where c.IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetControlCambiosTareas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetControlCambiosTareas`(in p_idTarea int)
BEGIN
    SELECT 
        t.*,ta.titulo as Tarea, e.Descripcion as Estado, ti.Descripcion as Pago
    FROM 
        tareascontrolcambios t
	inner join tareas ta on ta.IdTarea=t.IdTarea
    inner join estadostarea e on e.IdEstadoTarea=t.IdEstadoTarea
    inner join tipopago ti on ti.IdTipoPago=t.IdTipoPago
    where t.IdTarea=p_idTarea;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetDeduccionByEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDeduccionByEmpresa`(in p_IdEmpresa int)
BEGIN
    Select * from deducciones where IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetDeduccionEmpleados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDeduccionEmpleados`(
    IN p_Iddeduccion INT
)
BEGIN

    -- Retornar la Bonificaci√≥n completa con la descripci√≥n de los empleados
    SELECT 
        b.IdEmpleado as ID, 
        CONCAT(e.Nombre, ' ', e.Apellido, ' / ', e.Rut) AS Descripcion
    FROM 
        deduccionesempleados b
    JOIN empleados e ON b.IdEmpleado = e.IdEmpleado
    WHERE b.IdDeduccion = p_Iddeduccion;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetDeduccionesEmpleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDeduccionesEmpleado`(
    IN p_IdEmpleado INT,
    IN p_IdEmpresa INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    SELECT 
        d.IdDeduccion, 
        d.Descripcion, 
        d.Monto, 
        d.FechaAplicacion,
        'General (para todos)' AS TipoBonificacion
    FROM deducciones d
    WHERE d.IdEmpresa = p_IdEmpresa and d.Estado = 1
    AND NOT EXISTS (
        SELECT 1 
        FROM deduccionesempleados de 
        WHERE de.IdDeduccion = d.IdDeduccion
    )
    UNION 
    -- Obtener bonificaciones asignadas espec√≠ficamente al empleado dentro de la empresa
    SELECT 
        d.IdDeduccion, 
        d.Descripcion, 
        d.Monto, 
        d.FechaAplicacion,
        'Asignada al empleado' AS TipoBonificacion
    FROM deducciones d
    INNER JOIN deduccionesempleados de 
        ON de.IdDeduccion = d.IdDeduccion
    WHERE de.IdEmpleado = p_IdEmpleado and d.Estado = 1
    AND d.IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetDetalleFiniquito` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDetalleFiniquito`(IN p_IdFiniquito INT)
BEGIN
    SELECT 
        Descripcion,
        Monto
    FROM 
        finiquitodetalle 
    WHERE IdFiniquito = p_IdFiniquito;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleados`(IN p_IdEmpresa INT)
BEGIN
    SELECT e.*, em.Nombre as Empresa, r.Descripcion as Cargo FROM empleados e
    inner join empresas em on em.IdEmpresa=e.IdEmpresa
    inner join roles r on r.IdRol = e.IdRol 
    inner join 
		estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
	inner join
		regimensalud rs on rs.idRegimenSalud = e.IdSalud
	INNER JOIN 
		afp a on a.idAFP = e.IdAFP
	where e.IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosALL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosALL`(IN p_IdEmpresa INT)
BEGIN
    SELECT 
    e.*, 
    em.Nombre as Empresa, 
    r.Descripcion as Cargo,
    CASE 
        WHEN c.IdContrato IS NULL THEN 'NO' 
        WHEN c.IdTipoContrato = 1 AND c.FechaFin BETWEEN NOW() AND DATE_ADD(NOW(), INTERVAL 15 DAY) THEN 'Pronto'
        ELSE 'SI' 
    END as Contrato 
FROM 
    empleados e
    INNER JOIN empresas em ON em.IdEmpresa = e.IdEmpresa
    INNER JOIN roles r ON r.IdRol = e.IdRol 
    INNER JOIN estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
    INNER JOIN regimensalud rs ON rs.idRegimenSalud = e.IdSalud
    INNER JOIN afp a ON a.idAFP = e.IdAFP
    LEFT JOIN contratos c ON c.IdEmpleado = e.IdEmpleado 
        AND c.Estado = 1
        AND (NOW() BETWEEN FechaInicio AND FechaFin OR c.IdTipoContrato IN (2, 3, 4, 5))
WHERE 
    e.IdEmpresa = p_IdEmpresa 
    AND e.Estado = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosByID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosByID`(IN p_IdEmpleado VARCHAR(8), IN p_IdEmpresa INT)
BEGIN
    SELECT 
        e.*, 
        em.Nombre AS Empresa, 
        r.Descripcion AS Cargo,
        ec.Descripcion as EstadoCivil,
        rs.Descripcion as Salud,
        a.Descripcion as AFP
    FROM 
        empleados e
    INNER JOIN 
        empresas em ON em.IdEmpresa = e.IdEmpresa
    INNER JOIN 
        roles r ON r.IdRol = e.IdRol 
	inner join 
		estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
	inner join
		regimensalud rs on rs.idRegimenSalud = e.IdSalud
	INNER JOIN 
		afp a on a.idAFP = e.IdAFP
    WHERE 
        e.IdEmpleado=p_IdEmpleado and e.IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosContratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosContratos`(IN p_IdEmpresa INT)
BEGIN
    SELECT e.*, em.Nombre as Empresa, r.Descripcion as Cargo FROM empleados e
    inner join empresas em on em.IdEmpresa=e.IdEmpresa
    inner join roles r on r.IdRol = e.IdRol 
    inner join 
		estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
	inner join
		regimensalud rs on rs.idRegimenSalud = e.IdSalud
	INNER JOIN 
		afp a on a.idAFP = e.IdAFP
	where e.IdEmpresa=p_IdEmpresa and e.Estado=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosContratosActivos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosContratosActivos`(IN p_IdEmpresa INT)
BEGIN
    SELECT e.*, em.Nombre as Empresa, r.Descripcion as Cargo, c.IdContrato as IdContrato FROM empleados e
    inner join empresas em on em.IdEmpresa=e.IdEmpresa
    inner join roles r on r.IdRol = e.IdRol 
    inner join 
		estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
	inner join
		regimensalud rs on rs.idRegimenSalud = e.IdSalud
	INNER JOIN 
		afp a on a.idAFP = e.IdAFP
	INNER JOIN
		contratos c ON c.IdEmpleado = e.IdEmpleado
	where e.IdEmpresa=p_IdEmpresa and e.Estado=1 and c.Estado = 1 and (NOW() BETWEEN FechaInicio and FechaFin or c.IdTipoContrato in (2,3,4,5));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosnoTareas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosnoTareas`(IN p_idTarea INT, IN p_IdEmpresa INT)
BEGIN
    SELECT 
        e.*, 
        em.Nombre AS Empresa, 
        r.Descripcion AS Cargo,
        te.IdTareaEmpl,
        te.Idtarea
    FROM 
        empleados e
    INNER JOIN 
        empresas em ON em.IdEmpresa = e.IdEmpresa
    INNER JOIN 
        roles r ON r.IdRol = e.IdRol
	inner join 
		estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
	inner join
		regimensalud rs on rs.idRegimenSalud = e.IdSalud
	INNER JOIN 
		afp a on a.idAFP = e.IdAFP
    LEFT JOIN 
        tareasempleados te ON te.IdEmpleador = e.IdEmpleado AND te.IdTarea = p_idTarea
    WHERE 
        te.IdTarea IS NULL and e.IdEmpresa=p_IdEmpresa and e.Estado = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosPorBonificacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosPorBonificacion`(
    IN p_IdBonificacion INT,
    IN p_IdEmpresa INT
)
BEGIN
    -- Obtener los empleados asignados a una bonificaci√≥n espec√≠fica dentro de la empresa
    SELECT 
        e.IdEmpleado, 
        e.Nombre, 
        e.Apellido, 
        e.Rut, 
        e.Correo
    FROM empleados e
    INNER JOIN bonificacionesempleados be 
        ON e.IdEmpleado = be.IdEmpleado
    WHERE be.IdBonificacion = p_IdBonificacion
    AND e.IdEmpresa = p_IdEmpresa; -- Filtrar por empresa
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosRut` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosRut`(IN P_RUT VARCHAR(8), IN p_IdEmpresa INT)
BEGIN
    SELECT 
        e.*, 
        em.Nombre AS Empresa, 
        r.Descripcion AS Cargo,
        ec.Descripcion as EstadoCivil,
        rs.Descripcion as Salud,
        a.Descripcion as AFP
    FROM 
        empleados e
    INNER JOIN 
        empresas em ON em.IdEmpresa = e.IdEmpresa
    INNER JOIN 
        roles r ON r.IdRol = e.IdRol 
	inner join 
		estado_civil ec ON ec.idEstado_Civil = e.IdEstadoCivil
	inner join
		regimensalud rs on rs.idRegimenSalud = e.IdSalud
	INNER JOIN 
		afp a on a.idAFP = e.IdAFP
    WHERE 
        e.Rut LIKE CONCAT('%', P_RUT, '%') and e.IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosSinBonificacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosSinBonificacion`(
    IN p_IdEmpresa INT
)
BEGIN
    -- Obtener empleados de la empresa que no tienen bonificaciones asignadas
    SELECT 
        e.IdEmpleado, 
        e.Nombre, 
        e.Apellido, 
        e.Rut, 
        e.Correo
    FROM empleados e
    WHERE e.IdEmpresa = p_IdEmpresa
    AND NOT EXISTS (
        SELECT 1 
        FROM bonificacionesempleados be 
        WHERE be.IdEmpleado = e.IdEmpleado
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpleadosTareas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpleadosTareas`(in p_idTarea int)
BEGIN
    SELECT 
        t.*,e.Rut, e.Nombre,e.Apellido
    FROM 
        tareasempleados t
	inner join empleados e on e.IdEmpleado=t.IdEmpleador
    where t.IdTarea=p_idTarea and e.Estado = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpresas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpresas`()
BEGIN
    SELECT * FROM Empresas where Estado='Activo';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEmpresasById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEmpresasById`(in p_idEmpresa int)
BEGIN
    SELECT * FROM Empresas where IdEmpresa=p_idEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetEstadoCivil` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetEstadoCivil`()
BEGIN
    SELECT * FROM estado_civil;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetFiniquitoByContrato` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetFiniquitoByContrato`(IN p_IdContrato INT)
BEGIN
    SELECT * FROM dbpeopleflow.finiquitos where IdContrato=p_IdContrato;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetFiniquitoDetalleByID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetFiniquitoDetalleByID`(IN p_IdFiniquito INT)
BEGIN
    SELECT Descripcion,
        Monto FROM dbpeopleflow.finiquitodetalle where IdFiniquito=p_IdFiniquito;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetFiniquitoPlanilla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetFiniquitoPlanilla`()
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select * from Documentosplanilla where idplanilla=3;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetFiniquitos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetFiniquitos`(IN p_IdEmpresa INT)
BEGIN
	SELECT f.*,c.*,e.Rut,e.Nombre,e.Apellido,r.Descripcion as Cargo, t.Descripcion as TipoContrato, p.Descripcion as Plazo, ta.Titulo as Tarea
    FROM dbpeopleflow.finiquitos f
    inner join contratos c on c.IdContrato=f.IdContrato
    inner join empleados e on e.IdEmpleado=c.IdEmpleado
    inner join roles r on r.IdRol=e.IdRol
    inner join tipocontratos t on t.IdTipoContrato=c.IdTipoContrato
    inner join tareas ta on ta.IdTarea=c.IdTarea
    left join plazos p on p.IdPlazo = c.IdPlazo
    where c.IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetHorasTrabajadasVsEsperadas_Semanal` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetHorasTrabajadasVsEsperadas_Semanal`(
    IN p_IdEmpresa INT
)
BEGIN
    
	select 
	YEARWEEK(ta.FechaAsignacion, 3) AS Semana,
	ta.IdEmpleado,
	CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
	j.HorasSemanales AS HorasEsperadas,
	SUM(TIMESTAMPDIFF(HOUR, STR_TO_DATE(ta.HoraInicio, '%H:%i'), STR_TO_DATE(ta.HoraTermino, '%H:%i'))) AS HorasTrabajadas 
	from tareasempleadosasistencia ta
	INNER JOIN tareas t ON t.IdTarea = ta.IdTarea
	inner join jornadas j on t.IdJornada=j.idJornadas
	INNER JOIN empleados e on e.IdEmpleado=ta.IdEmpleado
	where t.IdEmpresa=p_IdEmpresa and ta.FechaAsignacion >= DATE_SUB(CURDATE(), INTERVAL 3 MONTH)  -- Solo √∫ltimos 3 meses
	GROUP BY Semana,ta.IdEmpleado,Empleado,j.HorasSemanales
	ORDER BY Semana;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetJornadas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetJornadas`(IN p_IdEmpresa INT)
BEGIN
    SELECT * FROM jornadas where IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetJornadasID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetJornadasID`(IN p_IdJornada INT)
BEGIN
    SELECT * FROM jornadas where idJornadas=p_IdJornada;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetLiquidacionById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLiquidacionById`(
    IN p_IdLiquidacion INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select l.*, concat(e.Nombre, ' ', e.Apellido) as NombreEmpleado from liquidaciones l
    inner join empleados e on e.IdEmpleado=l.IdEmpleado
    where l.IdLiquidacion=p_IdLiquidacion;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetLiquidacionByPeriodo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLiquidacionByPeriodo`(in p_periodo varchar(200),in p_IdTrabajador int)
BEGIN
    select * from liquidaciones  where Periodo=p_periodo and IdEmpleado = p_IdTrabajador;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetLiquidacionByTrabajador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLiquidacionByTrabajador`(
    IN p_IdTrabajador INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select l.*, concat(e.Nombre, ' ', e.Apellido) as NombreEmpleado from liquidaciones l
    inner join empleados e on e.IdEmpleado=l.IdEmpleado
    where l.IdEmpleado=p_IdTrabajador;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetLiquidacionesByEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLiquidacionesByEmpresa`(in p_IdEmpresa int)
BEGIN
    Select l.*, concat(e.Nombre, ' ', e.Apellido) as NombreEmpleado from liquidaciones l
    inner join empleados e on e.IdEmpleado=l.IdEmpleado
    where l.IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetLiquidacionesEmpresaPeriodo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLiquidacionesEmpresaPeriodo`(in p_IdEmpresa int, in p_year varchar(45), in p_month varchar(45))
BEGIN
    Select l.*, concat(e.Nombre, ' ', e.Apellido) as NombreEmpleado from liquidaciones l
    inner join empleados e on e.IdEmpleado=l.IdEmpleado
    where l.IdEmpresa = p_IdEmpresa and year=p_year and month=p_month;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetLiquidacionPlanilla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetLiquidacionPlanilla`(
    IN p_IdLiquidacion INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select * from Documentosplanilla where idplanilla=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetPlazos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPlazos`()
BEGIN
    SELECT * FROM plazos;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetProductividadPorEmpleado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetProductividadPorEmpleado`(
    IN p_IdEmpresa INT
)
BEGIN
    SELECT 
        e.IdEmpleado,
        CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
        tp.Descripcion,  -- Este campo debe existir en la tabla tareas para diferenciar por hora, tarea o trato
        SUM(tr.Cantidad) AS TotalCantidad,
        SUM(tr.Cantidad * t.Valor)+(sum(tr.PagoIndividual)) AS TotalPago
    FROM tareasempleadosregistro tr
    INNER JOIN tareas t ON t.IdTarea = tr.IdTarea
    INNER JOIN tipopago tp on tp.IdTipoPago = t.IdTipoPago
    INNER JOIN empleados e ON e.IdEmpleado = tr.IdEmpleado
    WHERE e.IdEmpresa = p_IdEmpresa
    GROUP BY e.IdEmpleado, t.IdTipoPago;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetProductividadPorMes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetProductividadPorMes`(
    IN p_IdEmpresa INT
)
BEGIN
    SELECT 
        e.IdEmpleado,
        CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
        DATE_FORMAT(tr.FechaAsignacion, '%Y-%m') AS Mes,  -- Agrupar por A√±o-Mes
        SUM(tr.Cantidad) AS TotalCantidad,
        SUM(tr.Cantidad * tr.PagoIndividual) AS TotalPago
    FROM tareasempleadosregistro tr
    INNER JOIN tareas t ON t.IdTarea = tr.IdTarea
    INNER JOIN empleados e ON e.IdEmpleado = tr.IdEmpleado
    WHERE e.IdEmpresa = p_IdEmpresa
    GROUP BY e.IdEmpleado, Mes  -- Agrupar por empleado y mes
    ORDER BY Mes, e.IdEmpleado;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetRegistroActividades` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRegistroActividades`(
    IN p_IdEmpresa INT,
    IN p_FINI DATE,
    IN p_FFin DATE,
    IN p_Tarea INT,
    IN p_IdEmpleado INT
)
BEGIN


	SELECT  e.Rut, e.Nombre,e.Apellido,t.Titulo,t.IdTarea,tr.FechaAsignacion,tr.Cantidad,tr.PagoIndividual, t.Valor as ValorUnitario, (t.Valor * tr.Cantidad) as Total,'NO' as Horario FROM dbpeopleflow.tareasempleadosregistro tr
	inner join tareas t on t.IdTarea=tr.IdTarea
	inner join empleados e on e.IdEmpleado=tr.IdEmpleado
	where t.IdEmpresa = p_IdEmpresa
    AND tr.FechaAsignacion BETWEEN p_FINI AND p_FFin
    AND (p_Tarea = 0 OR t.IdTarea = p_Tarea)
        AND (p_IdEmpleado = 0 OR e.IdEmpleado = p_IdEmpleado)
	UNION ALL
    Select e.Rut, e.Nombre,e.Apellido,t.Titulo,t.IdTarea,ta.FechaAsignacion,concat(ta.HoraInicio,'|',HoraTermino) as Cantidad,0 as PagoIndividual, t.Valor as ValorUnitario, (t.Valor * 1) as Total,'SI' as Horario from tareasempleadosasistencia ta
    inner join tareas t on t.IdTarea=ta.IdTarea
    inner join empleados e on e.IdEmpleado=ta.IdEmpleado
    where t.IdEmpresa = p_IdEmpresa
    AND ta.FechaAsignacion BETWEEN p_FINI AND p_FFin
    AND (p_Tarea = 0 OR t.IdTarea = p_Tarea)
        AND (p_IdEmpleado = 0 OR e.IdEmpleado = p_IdEmpleado);


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetRoles` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRoles`(IN p_IdEmpresa INT)
BEGIN
    SELECT * FROM roles where IdEmpresa=p_IdEmpresa and Estado=1;
    -- where IdEmpresa=p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetSaludEmpleados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetSaludEmpleados`(IN p_IdEmpresa INT)
BEGIN
    SELECT * FROM regimensalud;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareaAsistencia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareaAsistencia`(
    IN p_IdTarea INT,
    IN p_FAsignacion DATE,
    IN p_IdEmpleado INT
)
BEGIN


	select * from tareasempleadosasistencia where IdTarea = p_IdTarea and IdEmpleado=p_IdEmpleado and FechaAsignacion=p_FAsignacion;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareaRegistro` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareaRegistro`(
    IN p_IdTarea INT,
    IN p_FAsignacion DATE,
    IN p_IdEmpleado INT
)
BEGIN


	select * from tareasempleadosregistro where IdTarea = p_IdTarea and IdEmpleado=p_IdEmpleado and FechaAsignacion=p_FAsignacion;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareas`(IN p_IdEpmpresa INT)
BEGIN
    SELECT 
        t.*,p.Descripcion as Pago, e.Descripcion as Estado
    FROM 
        Tareas t
    INNER JOIN 
        estadostarea e ON e.IdEstadoTarea = t.IdEstadoTarea
    INNER JOIN 
        tipopago p ON p.IdTipoPago = t.IdTipoPago 
	where t.IdEmpresa=p_IdEpmpresa and t.IdEstadoTarea=2;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareasALL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareasALL`(IN p_IdEpmpresa INT)
BEGIN
    SELECT 
    t.*,
    p.Descripcion as Pago, 
    e.Descripcion as Estado,
    CASE 
        WHEN j.HoraInFinSemana IS NOT NULL THEN
            CONCAT(j.DiaComienzo, ' ', j.DiaTermino, ' ', 
                   j.HoraInSemana, '-', j.HoraOutSemana, ' | ',
                   j.HoraInFinSemana, '-', j.HoraOutFinSemana)
        ELSE
            CONCAT(j.DiaComienzo, ' ', j.DiaTermino, ' ',
                   j.HoraInSemana, '-', j.HoraOutSemana)
    END as Jornada
	FROM 
		Tareas t
	INNER JOIN 
		estadostarea e ON e.IdEstadoTarea = t.IdEstadoTarea
	INNER JOIN 
		tipopago p ON p.IdTipoPago = t.IdTipoPago 
	INNER JOIN
		jornadas j ON j.idJornadas = t.IdJornada
	WHERE 
		t.IdEmpresa = p_IdEpmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareasByID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareasByID`(IN p_IDTarea INT)
BEGIN
    SELECT 
        t.*,p.Descripcion as Pago, e.Descripcion as Estado
    FROM 
        Tareas t
    INNER JOIN 
        estadostarea e ON e.IdEstadoTarea = t.IdEstadoTarea
    INNER JOIN 
        tipopago p ON p.IdTipoPago = t.IdTipoPago 
	where t.IdTarea=p_IDTarea;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareasConEmpleados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareasConEmpleados`(IN p_IdEmpresa INT)
BEGIN
    SELECT 
        t.*,
        p.Descripcion AS Pago,
        e.Descripcion AS Estado,
        COALESCE(empleadosAsignados.TotalEmpleados, 0) AS TotalEmpleados, -- Empleados activos asignados a la tarea
        COALESCE(tareasHoy.TotalTareasRegistradas, 0) + COALESCE(asistenciasHoy.TotalAsistenciasRegistradas, 0) AS TareasRegistradasHoy, -- Registros combinados de ambas tablas
        COALESCE(empleadosAsignados.TotalEmpleados, 0) - (COALESCE(tareasHoy.TotalTareasRegistradas, 0) + COALESCE(asistenciasHoy.TotalAsistenciasRegistradas, 0)) AS TareasFaltantes -- Empleados que a√∫n no registran tarea hoy
    FROM 
        Tareas t
    INNER JOIN 
        estadostarea e ON e.IdEstadoTarea = t.IdEstadoTarea
    INNER JOIN 
        tipopago p ON p.IdTipoPago = t.IdTipoPago
    LEFT JOIN (
        -- Contar empleados activos asignados a la tarea
        SELECT 
            te.IdTarea,
            COUNT(te.IdEmpleador) AS TotalEmpleados
        FROM 
            tareasempleados te
        INNER JOIN 
            empleados emp ON emp.IdEmpleado = te.IdEmpleador
        WHERE 
            emp.Estado = 1 -- Solo empleados activos
        GROUP BY 
            te.IdTarea
    ) AS empleadosAsignados ON empleadosAsignados.IdTarea = t.IdTarea
    LEFT JOIN (
        -- Contar cu√°ntas tareas han sido registradas hoy en tareasempleadosregistro
        SELECT 
            ter.IdTarea,
            COUNT(ter.IdEmpleado) AS TotalTareasRegistradas
        FROM 
            tareasempleadosregistro ter
        WHERE 
            DATE(ter.FechaAsignacion) = CURDATE() -- Solo registros del d√≠a actual
        GROUP BY 
            ter.IdTarea
    ) AS tareasHoy ON tareasHoy.IdTarea = t.IdTarea
    LEFT JOIN (
        -- Contar cu√°ntas asistencias han sido registradas hoy en tareasempleadosasistencia
        SELECT 
            tea.IdTarea,
            COUNT(tea.IdEmpleado) AS TotalAsistenciasRegistradas
        FROM 
            tareasempleadosasistencia tea
        WHERE 
            DATE(tea.FechaAsignacion) = CURDATE() -- Solo registros del d√≠a actual
        GROUP BY 
            tea.IdTarea
    ) AS asistenciasHoy ON asistenciasHoy.IdTarea = t.IdTarea
    WHERE 
        t.IdEmpresa = p_IdEmpresa 
        AND t.IdEstadoTarea = 2; -- Solo tareas con estado 2

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareasEstados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareasEstados`()
BEGIN
    SELECT 
        *
    FROM 
        estadostarea;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTareasNoPagada` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTareasNoPagada`(
    IN p_IdEmpleado INT,
    IN p_MES INT
)
BEGIN
    SELECT  
        *
    FROM 
        tareasempleadosregistro 
    WHERE 
        IdEmpleado = p_IdEmpleado 
        AND MONTH(FechaAsignacion) = p_MES
    ORDER BY 
        FechaAsignacion DESC ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTasaAusentismoSemanal` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTasaAusentismoSemanal`(
    IN p_IdEmpresa INT
)
BEGIN
    -- Primero obtenemos la tarea principal por empleado (puedes cambiar el criterio de selecci√≥n)
    WITH TareaPrincipal AS (
        SELECT 
            te.IdEmpleador,
            te.IdTarea,
            ROW_NUMBER() OVER (PARTITION BY te.IdEmpleador ORDER BY te.IdTarea) AS RowNum
        FROM tareasempleados te
        INNER JOIN tareas t ON t.IdTarea = te.IdTarea
        INNER JOIN empleados e ON e.IdEmpleado = te.IdEmpleador
        WHERE e.IdEmpresa = p_IdEmpresa
    )
    
    SELECT 
        YEARWEEK(ta.FechaAsignacion, 3) AS Semana,
        e.IdEmpleado,
        CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
        j.Descripcion AS Jornada,
        
        -- D√≠as esperados seg√∫n la jornada
        CASE 
            WHEN j.DiaTermino = 'Viernes' THEN 5
            WHEN j.DiaTermino = 'S√°bado' THEN 6
            WHEN j.DiaTermino = 'Domingo' THEN 7
            ELSE 5
        END AS DiasEsperados,
        
        -- D√≠as asistidos en la semana
        COUNT(DISTINCT ta.FechaAsignacion) AS DiasAsistidos,
        
        -- Tasa de ausentismo (%)
        ROUND(100 * (
            (CASE 
                WHEN j.DiaTermino = 'Viernes' THEN 5
                WHEN j.DiaTermino = 'S√°bado' THEN 6
                WHEN j.DiaTermino = 'Domingo' THEN 7
                ELSE 5
            END - COUNT(DISTINCT ta.FechaAsignacion)) 
            / 
            CASE 
                WHEN j.DiaTermino = 'Viernes' THEN 5
                WHEN j.DiaTermino = 'S√°bado' THEN 6
                WHEN j.DiaTermino = 'Domingo' THEN 7
                ELSE 5
            END
        ), 2) AS TasaAusentismo
        
    FROM empleados e
    INNER JOIN TareaPrincipal tp ON tp.IdEmpleador = e.IdEmpleado AND tp.RowNum = 1
    INNER JOIN tareas t ON t.IdTarea = tp.IdTarea
    INNER JOIN jornadas j ON j.idJornadas = t.IdJornada
    LEFT JOIN tareasempleadosasistencia ta ON ta.IdEmpleado = e.IdEmpleado 
        AND ta.FechaAsignacion BETWEEN DATE_SUB(CURDATE(), INTERVAL 3 MONTH) AND CURDATE()
    
    WHERE e.IdEmpresa = p_IdEmpresa
        AND e.Estado = 1  -- Solo empleados activos
    
    GROUP BY Semana, e.IdEmpleado, Empleado, Jornada, j.DiaTermino
    HAVING Semana IS NOT NULL
    ORDER BY Semana, TasaAusentismo DESC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTasaAusentismo_Semanal` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTasaAusentismo_Semanal`(
    IN p_IdEmpresa INT
)
BEGIN
    WITH SemanaDias AS (
        SELECT 
            e.IdEmpleado,
            YEARWEEK(t.FechaAsignacion, 3) AS Semana,
            j.DiaComienzo,
            j.DiaTermino,
            (j.DiaTermino - j.DiaComienzo + 1) AS DiasEsperados
        FROM empleados e
        INNER JOIN tareas t ON t.IdEmpresa = e.IdEmpresa
        INNER JOIN jornadas j ON j.IdJornadas = t.IdJornada
        WHERE e.IdEmpresa = p_IdEmpresa
    ),
    Asistencias AS (
        SELECT 
            ta.IdEmpleado,
            YEARWEEK(ta.FechaAsignacion, 3) AS Semana,
            COUNT(DISTINCT ta.FechaAsignacion) AS DiasAsistidos
        FROM tareasempleadosasistencia ta
        INNER JOIN empleados e ON e.IdEmpleado = ta.IdEmpleado
        WHERE e.IdEmpresa = p_IdEmpresa
            AND ta.FechaAsignacion >= DATE_SUB(CURDATE(), INTERVAL 3 MONTH)
        GROUP BY ta.IdEmpleado, Semana
    )
    SELECT 
        sd.Semana,
        e.IdEmpleado,
        CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
        sd.DiasEsperados,
        COALESCE(a.DiasAsistidos, 0) AS DiasAsistidos,
        (sd.DiasEsperados - COALESCE(a.DiasAsistidos, 0)) AS DiasAusentes,
        ROUND(((sd.DiasEsperados - COALESCE(a.DiasAsistidos, 0)) / sd.DiasEsperados) * 100, 2) AS TasaAusentismo
    FROM SemanaDias sd
    LEFT JOIN Asistencias a ON sd.IdEmpleado = a.IdEmpleado AND sd.Semana = a.Semana
    INNER JOIN empleados e ON e.IdEmpleado = sd.IdEmpleado
    ORDER BY sd.Semana, Empleado;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTipoContrato` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTipoContrato`()
BEGIN
    SELECT * FROM tipocontratos;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTipoDetalleFiniquito` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTipoDetalleFiniquito`()
BEGIN
    select * from finiquitostipodetalle;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTipoFiniquito` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTipoFiniquito`()
BEGIN
    SELECT * FROM dbpeopleflow.tipofiniquito;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTipoPago` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTipoPago`()
BEGIN
    SELECT 
        *
    FROM 
        tipopago;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetUltima3Liquidaciones` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUltima3Liquidaciones`(IN p_IdContrato INT)
BEGIN
    SELECT  
        *
    FROM 
        liquidaciones 
    WHERE IdContrato = p_IdContrato order by FechaGeneracion desc limit 3;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetUltimaVacacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUltimaVacacion`(IN p_IdEmpleado INT)
BEGIN
    SELECT  
        *
    FROM 
        vacaciones 
    WHERE IdEmpleado = p_IdEmpleado order by FechaRegistro desc limit 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetUsuariosByEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUsuariosByEmpresa`(in p_IdEmpresa int)
BEGIN
    Select * from usuarios
    where IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetVacacionesByEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetVacacionesByEmpresa`(in p_IdEmpresa int)
BEGIN
    Select v.*,concat(e.Nombre,' ',e.Apellido) as Nombre, e.Rut from vacaciones v
    inner join empleados e on e.IdEmpleado=v.IdEmpleado
    where v.IdEmpresa = p_IdEmpresa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetVacacionesByID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetVacacionesByID`(in p_IdVacaciones int)
BEGIN
    Select * from vacaciones
    where idVacaciones = p_IdVacaciones;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetVacacionesPlanilla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetVacacionesPlanilla`(
    IN p_IdLiquidacion INT
)
BEGIN
    -- Obtener bonificaciones generales (Para todos) de la empresa
    select * from Documentosplanilla where idplanilla=2;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetValoresCargas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetValoresCargas`()
BEGIN
    select * from valorescargas ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Login` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Login`(
    IN p_user VARCHAR(50),
    IN p_id_empresa INT
)
BEGIN
    SELECT 
        u.*, 
        e.Nombre AS Empresa, 
        r.Descripcion AS Cargo
    FROM 
        usuarios u
    INNER JOIN 
        empresas e ON e.IdEmpresa = u.IdEmpresa
    INNER JOIN 
        roles r ON r.IdRol = u.IdRol
    WHERE 
        u.NombreUsuario = p_user 
        AND u.IdEmpresa = p_id_empresa 
        AND u.Estado = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ObtenerSaldoVacacionesChile` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerSaldoVacacionesChile`(
    IN p_IdEmpleado INT
)
BEGIN
    DECLARE v_FechaContratacion DATE;
    DECLARE v_AniosAntiguedad INT;
    DECLARE v_DiasBasePorMes DECIMAL(5,2) DEFAULT 1.25; -- 15 d√≠as / 12 meses
    DECLARE v_DiasProgresivos INT DEFAULT 0;
    DECLARE v_MesesTrabajadosAnioActual INT;
    DECLARE v_DiasBaseCalculados DECIMAL(5,2);
    DECLARE v_DiasAcumuladosAnioActual DECIMAL(5,2);
    DECLARE v_DiasPendientesAnioAnterior DECIMAL(5,2);
    DECLARE v_DiasVacacionesTomadosAnioActual INT;
    DECLARE v_DiasVacacionesTomadosAnioAnterior INT;
    DECLARE v_SaldoTotal DECIMAL(5,2);
    
    -- 1. Obtener fecha de contrataci√≥n (√∫ltimo contrato activo)
    SELECT FechaInicio INTO v_FechaContratacion
    FROM contratos
    WHERE IdEmpleado = p_IdEmpleado 
    AND Estado = 1
    ORDER BY FechaInicio DESC
    LIMIT 1;
    
    -- 2. Calcular a√±os de antig√ºedad
    SET v_AniosAntiguedad = TIMESTAMPDIFF(YEAR, v_FechaContratacion, CURDATE());
    
    -- 3. Aplicar d√≠as progresivos seg√∫n antig√ºedad
    IF v_AniosAntiguedad >= 5 AND v_AniosAntiguedad < 10 THEN
        SET v_DiasProgresivos = 1;
    ELSEIF v_AniosAntiguedad >= 10 AND v_AniosAntiguedad < 15 THEN
        SET v_DiasProgresivos = 2;
    ELSEIF v_AniosAntiguedad >= 15 THEN
        SET v_DiasProgresivos = 3;
    END IF;
    
    -- 4. Calcular meses trabajados en el a√±o actual (proporcional)
    SET v_MesesTrabajadosAnioActual = TIMESTAMPDIFF(MONTH, 
        GREATEST(v_FechaContratacion, DATE_FORMAT(CURDATE(), '%Y-01-01')), 
        CURDATE()) + 1;
    
    -- Asegurar no exceder 12 meses
    IF v_MesesTrabajadosAnioActual > 12 THEN
        SET v_MesesTrabajadosAnioActual = 12;
    END IF;
    
    -- 5. Calcular d√≠as base proporcionales (1.25 por mes)
    SET v_DiasBaseCalculados = v_DiasBasePorMes * v_MesesTrabajadosAnioActual;
    
    -- 6. Calcular d√≠as acumulados a√±o actual (base + progresivos)
    SET v_DiasAcumuladosAnioActual = v_DiasBaseCalculados + 
        (v_DiasProgresivos * (v_MesesTrabajadosAnioActual/12));
    
    -- 7. Calcular d√≠as pendientes del a√±o anterior (m√°ximo 15 d√≠as)
    SELECT 
        IFNULL(SUM(CASE WHEN YEAR(FechaIni) = YEAR(CURDATE())-1 THEN CantDias ELSE 0 END), 0),
        IFNULL(15 - SUM(CASE WHEN YEAR(FechaIni) = YEAR(CURDATE())-1 THEN CantDias ELSE 0 END), 15)
    INTO v_DiasVacacionesTomadosAnioAnterior, v_DiasPendientesAnioAnterior
    FROM vacaciones
    WHERE IdEmpleado = p_IdEmpleado
    AND YEAR(FechaIni) = YEAR(CURDATE())-1;
    
    -- Ajustar d√≠as pendientes (no negativos y m√°ximo 15)
    SET v_DiasPendientesAnioAnterior = GREATEST(LEAST(v_DiasPendientesAnioAnterior, 15), 0);
    
    -- 8. Obtener d√≠as tomados en el a√±o actual
    SELECT IFNULL(SUM(CantDias), 0) INTO v_DiasVacacionesTomadosAnioActual
    FROM vacaciones
    WHERE IdEmpleado = p_IdEmpleado
    AND YEAR(FechaIni) = YEAR(CURDATE());
    
    -- 9. Calcular saldo total (pendientes + acumulados - tomados)
    SET v_SaldoTotal = v_DiasPendientesAnioAnterior + v_DiasAcumuladosAnioActual - v_DiasVacacionesTomadosAnioActual;
    
    -- 10. Retornar resultados
    SELECT 
        ROUND(v_SaldoTotal, 2) AS SaldoVacaciones,
        15 AS DiasLegalesAnuales,
        v_DiasProgresivos AS DiasProgresivos,
        v_DiasVacacionesTomadosAnioActual AS DiasTomadosAnioActual,
        v_DiasVacacionesTomadosAnioAnterior AS DiasTomadosAnioAnterior,
        ROUND(v_DiasPendientesAnioAnterior, 2) AS DiasPendientesAnioAnterior,
        ROUND(v_DiasBaseCalculados, 2) AS DiasBaseCalculados,
        ROUND(v_DiasAcumuladosAnioActual, 2) AS DiasAcumuladosAnioActual,
        v_MesesTrabajadosAnioActual AS MesesTrabajadosAnioActual;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroAnexosContratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroAnexosContratos`(
    IN p_IdAnexo INT,
    IN p_IdContrato INT,
    IN p_Titulo varchar(256),
    IN p_archivo TEXT,
    IN p_IdEmpresa INT,
    IN p_IdUsuario INT,
    IN p_ArchivoB LONGBLOB
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT

        INSERT INTO anexocontrato (IdContrato, Titulo, Archivo, FechaReg, Usuario, IdEmpresa,ArchivoB)
        VALUES (p_IdContrato, p_Titulo,p_archivo,NOW(),p_IdUsuario,p_IdEmpresa,p_ArchivoB);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdAnexo = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','anexocontrato',p_IdAnexo);

		select * from anexocontrato where idAnexoContrato=p_IdAnexo;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroArchivosEmpresa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroArchivosEmpresa`(
    IN p_IdArchivo INT,
    IN p_Titulo varchar(256),
    IN p_archivo TEXT,
    IN p_IdEmpresa INT,
    IN p_IdUsuario INT,
    IN p_ArchivoB LONGBLOB
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT

        INSERT INTO ArchivosEmpresa (Titulo, Archivo, FechaReg, Usuario, IdEmpresa,ArchivoB)
        VALUES (p_Titulo,p_archivo,NOW(),p_IdUsuario,p_IdEmpresa,p_ArchivoB);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdArchivo = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','ArchivosEmpresa',p_IdArchivo);

		select * from ArchivosEmpresa where idArchivos=p_IdArchivo;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroAsignacionFamiliar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroAsignacionFamiliar`(
    IN p_IdAsigFamilia INT,
    IN p_IdEmpleador INT,
    IN p_NHijos INT,
    IN p_NConyuge INT,
    IN p_NInvalidez INT,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdAsigFamilia = 0 THEN
        INSERT INTO cargasempleados (IdEmpleado, NCargasHijos, NCargasConguye, NCargasInvalidez)
        VALUES (p_IdEmpleador, p_NHijos, p_NConyuge, p_NInvalidez);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdAsigFamilia = LAST_INSERT_ID();
        
		CALL RegistroHistorial(p_IdUsuario,'insert','cargasempleados',p_IdAsigFamilia);
        
    ELSE
		UPDATE cargasempleados set IdEmpleado = p_IdEmpleador, 
        NCargasHijos = p_NHijos, 
        NCargasConguye = p_NConyuge, 
        NCargasInvalidez  = p_NInvalidez where idCargasEmpleados=p_IdAsigFamilia;
        CALL RegistroHistorial(p_IdUsuario,'update','cargasempleados',p_IdAsigFamilia);
        
    END IF;
    
    select * from cargasempleados where idCargasEmpleados=p_IdAsigFamilia;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroAsignacionTarea` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroAsignacionTarea`(
    IN p_IdAsigTarea INT,
    IN p_Idtarea INT,
    IN p_IdEmpleador INT,
    IN p_FInicio datetime,
    IN p_FFinalizacion datetime,
    IN p_Usuario varchar(50),
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdAsigTarea = 0 THEN
        INSERT INTO tareasempleados (Idtarea, IdEmpleador, FechaIni, FechaFin, Usuario)
        VALUES (p_Idtarea, p_IdEmpleador, p_FInicio, p_FFinalizacion, p_Usuario);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdAsigTarea = LAST_INSERT_ID();
        
        INSERT INTO log_asignacionesetareas (IdAsignacion,IdEmpleado,FechaInicio,Usuario,Fecha_Creacion)
        values (p_IdAsigTarea,p_IdEmpleador,p_FInicio,p_Usuario,NOW());
        
        CALL RegistroHistorial(p_IdUsuario,'insert','tareasempleados',p_IdAsigTarea);
        
    ELSE
		UPDATE log_asignacionesetareas set FechaTermino=NOW()  where IdAsignacion=p_IdAsigTarea;
		-- Guardar en historial
        delete from tareasempleados where IdTareaEmpl=p_IdAsigTarea;
        
        
        CALL RegistroHistorial(p_IdUsuario,'update','tareasempleados',p_IdAsigTarea);
        
        
    END IF;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroBonificaciones` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroBonificaciones`(
    IN p_IdBonificacion INT,
    IN p_IdEmpresa int ,
    IN p_Descripcion VARCHAR(200),
    IN p_Monto decimal(18,2),
    IN p_FAsignacion DATE,
    IN p_Estado bit,
    IN p_paraEmpleado bit,
    IN p_IdTarea int,
    IN p_Imponible bit,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdBonificacion = 0 THEN
        INSERT INTO bonificaciones (IdEmpresa, Descripcion, Monto, FechaAplicacion, Estado,ParaEmpleado,IdTarea,Imponible)
        VALUES (p_IdEmpresa, p_Descripcion,p_Monto, p_FAsignacion, p_Estado,p_paraEmpleado,p_IdTarea,p_Imponible);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdBonificacion = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','bonificaciones',p_IdBonificacion);

    ELSE
        -- Si p_IdBonificacion no es 0, hacer UPDATE
        UPDATE bonificaciones
        SET 
            Descripcion = p_Descripcion,
            Monto = p_Monto,
            FechaAplicacion = p_FAsignacion,
            Estado = p_Estado,
            ParaEmpleado = p_paraEmpleado,
            IdTarea = p_IdTarea,
            Imponible = p_Imponible
        WHERE IdBonificacion = p_IdBonificacion;
        
        delete from bonificacionesempleados where IdBonificacion=p_IdBonificacion;
        CALL RegistroHistorial(p_IdUsuario,'update','bonificaciones',p_IdBonificacion);

    END IF;
    
    -- Limpiar RegistroBonificacionesEmpelados -- se llena nuemente
    
    

    -- Retornar la Bonificacion completa
    SELECT 
        b.*
    FROM 
        bonificaciones b
	WHERE b.IdBonificacion = p_IdBonificacion;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroBonificacionesEmpelados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroBonificacionesEmpelados`(
    IN p_IdBonificacionEmpleados INT,
    IN p_IdBonificacion INT,
    IN p_IdEmpleado INT,
    IN p_Usuario VARCHAR(45),
    IN p_Estado BIT,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdBonificacionEmpleados es 0, hacer INSERT
    IF p_IdBonificacionEmpleados = 0 THEN
        INSERT INTO bonificacionesempleados (IdBonificacion, IdEmpleado, Usuario, Estado, Fec_Crea)
        VALUES (p_IdBonificacion, p_IdEmpleado, p_Usuario, p_Estado, NOW());  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva bonificaci√≥n
        SET p_IdBonificacionEmpleados = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','bonificacionesempleados',p_IdBonificacionEmpleados);

    ELSE
        -- Si p_IdBonificacion no es 0, hacer UPDATE
        DELETE FROM bonificacionesempleados
        WHERE IdBonificacionesEmpleados = p_IdBonificacionEmpleados AND IdEmpleado = p_IdEmpleado;
        
        CALL RegistroHistorial(p_IdUsuario,'delete','bonificacionesempleados',p_IdBonificacionEmpleados);
    END IF;

    -- Retornar la Bonificaci√≥n completa con la descripci√≥n de los empleados
    SELECT 
        b.IdEmpleado as ID, 
        CONCAT(e.Nombre, ' ', e.Apellido, ' / ', e.Rut) AS Descripcion
    FROM 
        bonificacionesempleados b
    JOIN empleados e ON b.IdEmpleado = e.IdEmpleado
    WHERE b.IdBonificacion = p_IdBonificacion;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroCargos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroCargos`(
    IN p_IdCargos INT,
    IN p_IdEmpresa int ,
    IN p_Nombre Varchar(50),
    IN p_Estado bit,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdCargos = 0 THEN
        INSERT INTO roles (IdEmpresa, Descripcion, Estado,Fecha)
        VALUES (p_IdEmpresa, p_Nombre,p_Estado,NOW());  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdCargos = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','roles',p_IdCargos);
    ELSE
        -- Si p_IdBonificacion no es 0, hacer UPDATE
        UPDATE roles
        SET 
            Descripcion = p_Nombre,
            Estado = p_Estado
        WHERE IdRol = p_IdCargos;
        
        CALL RegistroHistorial(p_IdUsuario,'update','roles',p_IdCargos);

    END IF;
    
    -- Limpiar RegistroBonificacionesEmpelados -- se llena nuemente
    -- Retornar la Bonificacion completa
    SELECT 
        *
    FROM 
        roles
	WHERE IdRol = p_IdCargos;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroContrato` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroContrato`(
    IN p_IdContrato INT,
    IN p_IdEmpleado INT,
    IN p_FInicio DATEtime,
    IN p_FTermino DATEtime,
    IN p_IdTipoContrato INT,
    IN p_IdPlazo INT,
    IN p_NPlazo INT,
    IN p_Descripcion VARCHAR(200),
    IN p_Estado BIT,
    IN p_IdTarea INT,
    IN p_IdEmpresa INT,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdEmpleado es 0, hacer INSERT
    IF p_IdContrato = 0 THEN
        INSERT INTO contratos (IdEmpleado, FechaInicio, FechaFin, IdTipoContrato, IdPlazo, NPlazo, Descripcion, FechaCreacion, Estado,IdTarea,IdEmpresa)
        VALUES (p_IdEmpleado, p_FInicio, p_FTermino, p_IdTipoContrato, p_IdPlazo, p_NPlazo, p_Descripcion, NOW(), p_Estado,p_IdTarea,p_IdEmpresa);

        -- Obtener el ID del nuevo empleado
        SET p_IdContrato = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','contratos',p_IdContrato);

    ELSE
        -- Si p_IdEmpleado no es 0, hacer UPDATE
        UPDATE contratos
        SET 
            IdEmpleado = p_IdEmpleado,
            FechaInicio = p_FInicio,
            FechaFin = p_FTermino,
            IdTipoContrato = p_IdTipoContrato,
            IdPlazo = p_IdPlazo,
            NPlazo = p_NPlazo,
            Descripcion = p_Descripcion,
            Estado = p_Estado,
            IdTarea = p_IdTarea
        WHERE IdContrato = p_IdContrato;
        
        CALL RegistroHistorial(p_IdUsuario,'update','contratos',p_IdContrato);
    END IF;

    -- Retornar el empleado completo
    SELECT * FROM contratos WHERE IdContrato = p_IdContrato;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroDeducciones` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroDeducciones`(
    IN p_IdDeduccion INT,
    IN p_IdEmpresa int ,
    IN p_Descripcion VARCHAR(200),
    IN p_Monto decimal(18,2),
    IN p_FAsignacion DATE,
    IN p_Estado bit,
    IN p_paraEmpleado bit,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdDeduccion = 0 THEN
        INSERT INTO deducciones (IdEmpresa, Descripcion, Monto, FechaAplicacion, Estado,ParaEmpleado)
        VALUES (p_IdEmpresa, p_Descripcion,p_Monto, p_FAsignacion, p_Estado,p_paraEmpleado);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdDeduccion = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','deducciones',p_IdDeduccion);

    ELSE
        -- Si p_IdDeduccion no es 0, hacer UPDATE
        UPDATE deducciones
        SET 
            Descripcion = p_Descripcion,
            Monto = p_Monto,
            FechaAplicacion = p_FAsignacion,
            Estado = p_Estado,
            ParaEmpleado = p_paraEmpleado
        WHERE IdDeduccion = p_IdDeduccion;
        
        CALL RegistroHistorial(p_IdUsuario,'update','deducciones',p_IdDeduccion);

        
        delete from deduccionesempleados where IdDeduccion=p_IdDeduccion;
        
    END IF;
    
    -- Limpiar RegistroBonificacionesEmpelados -- se llena nuemente
    
    

    -- Retornar la Bonificacion completa
    SELECT 
        d.*
    FROM 
        deducciones d
	WHERE d.IdDeduccion = p_IdDeduccion;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroDeduccionesEmpleados` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroDeduccionesEmpleados`(
    IN p_IdDeduccionEmpleados INT,
    IN p_IdDeduccion INT,
    IN p_IdEmpleado INT,
    IN p_Usuario VARCHAR(45),
    IN p_Estado BIT,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdBonificacionEmpleados es 0, hacer INSERT
    IF p_IdDeduccionEmpleados = 0 THEN
        INSERT INTO deduccionesempleados (IdDeduccion, IdEmpleado, Usuario, Estado, Fec_Crea)
        VALUES (p_IdDeduccion, p_IdEmpleado, p_Usuario, p_Estado, NOW());  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva bonificaci√≥n
        SET p_IdDeduccionEmpleados = LAST_INSERT_ID();
        CALL RegistroHistorial(p_IdUsuario,'insert','deduccionesempleados',p_IdDeduccionEmpleados);
    ELSE
        -- Si p_IdBonificacion no es 0, hacer UPDATE
        DELETE FROM deduccionesempleados
        WHERE idDeduccionesEmpleados = p_IdDeduccionEmpleados AND IdEmpleado = p_IdEmpleado;
        CALL RegistroHistorial(p_IdUsuario,'delete','deduccionesempleados',p_IdDeduccionEmpleados);

    END IF;

    -- Retornar la Bonificaci√≥n completa con la descripci√≥n de los empleados
    SELECT 
        d.IdEmpleado as ID, 
        CONCAT(e.Nombre, ' ', e.Apellido, ' / ', e.Rut) AS Descripcion
    FROM 
        deduccionesempleados d
    JOIN empleados e ON d.IdEmpleado = e.IdEmpleado
    WHERE d.IdDeduccion = p_IdDeduccion;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroFiniquito` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroFiniquito`(
    IN p_IdFiniquito INT,
    IN p_IdContrato INT,
    IN p_FTermino DATE,
    IN p_IdTipoFiniquito INT,
    IN p_Observacion varchar(256),
    IN p_IdEmpresa INT,
    IN p_IdEstado BIT,
    IN p_IdUsuario varchar(20)
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdFiniquito = 0 THEN
        INSERT INTO finiquitos (IdContrato, FechaFiniquito, IdTipoFiniquito, Observacion, Fecha_Creacion, Usuario, IdEmpresa, Estado)
        VALUES (p_IdContrato, p_FTermino,p_IdTipoFiniquito,p_Observacion,NOW(),p_IdUsuario,p_IdEmpresa,p_IdEstado);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdFiniquito = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','finiquitos',p_IdFiniquito);

    ELSE
        -- Si p_IdTarea no es 0, hacer UPDATE
        
        delete from finiquitodetalle where IdFiniquito=p_IdFiniquito;
        
        UPDATE finiquitos
        SET 
            IdContrato=p_IdContrato,
            FechaFiniquito=p_FTermino,
            IdTipoFiniquito=p_IdTipoFiniquito,
            Observacion = p_Observacion,
            Estado=p_IdEstado
        WHERE idFiniquitos = p_IdFiniquito;
        
        CALL RegistroHistorial(p_IdUsuario,'update','finiquitos',p_IdFiniquito);

        
    END IF;

    -- Retornar la tarea completa
    SELECT 
        *
    FROM 
        finiquitos
	WHERE idFiniquitos = p_IdFiniquito;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroFiniquitoDetalle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroFiniquitoDetalle`(
    IN p_IdFiniquitoDetalle INT,
    IN p_IdFiniquito INT,
    IN p_Descripcion VARCHAR(156),
    IN p_Monto decimal(18,2),
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdBonificacionEmpleados es 0, hacer INSERT
    IF p_IdFiniquitoDetalle = 0 THEN
        INSERT INTO finiquitodetalle (IdFiniquito, Descripcion, Monto, Fecha_Creacion, Usuario)
        VALUES (p_IdFiniquito, p_Descripcion, p_Monto, NOW(),p_IdUsuario);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva bonificaci√≥n
        SET p_IdFiniquitoDetalle = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','finiquitodetalle',p_IdFiniquitoDetalle);

    ELSE
        -- Si p_IdBonificacion no es 0, hacer UPDATE
        DELETE FROM finiquitodetalle
        WHERE IdFiniquito = p_IdFiniquito;
        
        CALL RegistroHistorial(p_IdUsuario,'delete','finiquitodetalle',p_IdFiniquitoDetalle);
    END IF;

    -- Retornar la Bonificaci√≥n completa con la descripci√≥n de los empleados
    SELECT 
        Descripcion,
        Monto
    FROM 
        finiquitodetalle 
    WHERE IdFiniquito = p_IdFiniquito;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroHistorial` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroHistorial`(
    IN p_IdUsuario INT,
    IN p_Accion Varchar(50),
    IN p_Tabla Varchar(50),
    IN p_IdRegistro INT
)
BEGIN

        INSERT INTO historialacciones (IdUsuario, Accion, Tabla,Fecha,IdRegistro)
        VALUES (p_IdUsuario, p_Accion,p_Tabla,NOW(),p_IdRegistro);  -- Usar NOW() para fecha y hora actual


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroJornadas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroJornadas`(
    IN p_IdJornada INT,
    IN p_Descripcion varchar(45) ,
	IN p_DiaComienzo varchar(45) ,
    IN p_DiaTermino varchar(45) ,
    IN p_HoraInSemana varchar(45) ,
    IN p_HoraOutSemana varchar(45) ,
    IN p_HoraInFinSemana varchar(45) ,
    IN p_HoraOuFintSemana varchar(45) ,
	IN p_HorasSemanales INT,
    IN p_IdUsuario INT,
    IN p_IdEmpresa INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdJornada = 0 THEN
        INSERT INTO jornadas (Descripcion, DiaComienzo, DiaTermino, HoraInSemana, HoraOutSemana, HoraInFinSemana, HoraOutFinSemana, Fecha_creacion, Usuario, HorasSemanales, IdEmpresa)
        VALUES (p_Descripcion,p_DiaComienzo,p_DiaTermino,p_HoraInSemana,p_HoraOutSemana,p_HoraInFinSemana,p_HoraOuFintSemana,NOW(),p_IdUsuario,p_HorasSemanales,p_IdEmpresa);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdJornada = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','jornadas',p_IdJornada);
    ELSE
        -- Si p_IdBonificacion no es 0, hacer UPDATE
        UPDATE jornadas
        SET 
            Descripcion=p_Descripcion, 
            DiaComienzo=p_DiaComienzo,
            DiaTermino=p_DiaTermino, 
            HoraInSemana=p_HoraInSemana, 
            HoraOutSemana=p_HoraOutSemana, 
            HoraInFinSemana=p_HoraInFinSemana, 
            HoraOutFinSemana=p_HoraOuFintSemana, 
            HorasSemanales=p_HorasSemanales
        WHERE idJornadas = p_IdJornada;
        
        CALL RegistroHistorial(p_IdUsuario,'update','jornadas',p_IdJornada);
    END IF;
    
    -- Limpiar RegistroBonificacionesEmpelados -- se llena nuemente
    -- Retornar la Bonificacion completa
    
    SELECT 
        *
    FROM 
        jornadas
	WHERE idJornadas = p_IdJornada;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroLiquidacion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroLiquidacion`(
    IN p_IdLiquidacion INT,
    IN p_IdEmpleado INT,
    IN p_Periodo varchar(50),
    IN p_SalarioBase decimal(18,2),
    IN p_Bonificaciones decimal(18,2),
    IN p_Deducciones decimal(18,2),
    IN p_SueldoLiquido decimal(18,2),
    IN p_IdEmpresa INT,
    IN p_IdContrato INT,
    IN p_year varchar(25),
    IN p_month varchar(25),
    IN p_DescripcionBonos varchar(5000),
    IN p_DescripcionDeducciones varchar(5000),
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdEmpleado es 0, hacer INSERT
    IF p_IdLiquidacion = 0 THEN
        INSERT INTO liquidaciones (IdEmpleado, Periodo, SalarioBase, Bonificaciones, Deducciones, SueldoLiquido, FechaGeneracion, IdEmpresa, IdContrato,year,month,DescripcionBonos,DescripcionDeducciones)
        VALUES (p_IdEmpleado, p_Periodo, p_SalarioBase, p_Bonificaciones, p_Deducciones, p_SueldoLiquido, NOW(), p_IdEmpresa,p_IdContrato,p_year,p_month,p_DescripcionBonos,p_DescripcionDeducciones);

        -- Obtener el ID del nuevo empleado
        SET p_IdLiquidacion = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','liquidaciones',p_IdLiquidacion);
    ELSE
        -- Si p_IdEmpleado no es 0, hacer UPDATE
        UPDATE liquidaciones
        SET 
            IdEmpleado = p_IdEmpleado,
            Periodo = p_Periodo,
            SalarioBase = p_SalarioBase,
            Bonificaciones = p_Bonificaciones,
            Deducciones = p_Deducciones,
            SueldoLiquido = p_SueldoLiquido,
            FechaGeneracion = NOW(),
            year = p_year,
            month = p_month,
            DescripcionBonos = p_DescripcionBonos,
            DescripcionDeducciones = p_DescripcionDeducciones
        WHERE IdLiquidacion = p_IdLiquidacion;
        
        CALL RegistroHistorial(p_IdUsuario,'update','liquidaciones',p_IdLiquidacion);

    END IF;

    -- Retornar el empleado completo
    SELECT * FROM liquidaciones WHERE IdLiquidacion = p_IdLiquidacion;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroTarea` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroTarea`(
    IN p_IdTarea INT,
    IN p_Descripcion VARCHAR(500),
    IN p_FAsignacion DATE,
    IN p_FFinalizacion DATE,
    IN p_Idestado INT,
    IN p_IdPago INT,
    IN p_Valor DECIMAL(18,2),
    IN p_titulo varchar(45),
    IN p_IdJornada int,
    IN p_IdEmpresa int ,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdTarea = 0 THEN
        INSERT INTO tareas (Descripcion, FechaAsignacion, FechaFinalizacion, IdEstadoTarea, IdTipoPago, Valor, FechaModificacion,Titulo,IdJornada,IdEmpresa)
        VALUES (p_Descripcion, p_FAsignacion, p_FFinalizacion, p_Idestado, p_IdPago, p_Valor, NOW(),p_titulo,p_IdJornada,p_IdEmpresa);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdTarea = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','tareas',p_IdTarea);
    ELSE
		-- Guardar en historial
        INSERT INTO tareascontrolcambios (IdTarea,IdTipoPago,fechaInicio,FechaTermino,Valor,IdEstadoTarea)
        select t.IdTarea,t.IdTipoPago,t.FechaModificacion,NOW(),Valor,IdEstadoTarea from tareas t where t.IdTarea=p_IdTarea;
        
        -- Si p_IdTarea no es 0, hacer UPDATE
        UPDATE tareas
        SET 
            Descripcion = p_Descripcion,
            FechaAsignacion = p_FAsignacion,
            FechaFinalizacion = p_FFinalizacion,
            IdEstadoTarea = p_Idestado,
            IdTipoPago = p_IdPago,
            Valor = p_Valor,
            FechaModificacion = NOW(),  -- Usar NOW() para fecha y hora actual
            Titulo = p_titulo,
            IdJornada=p_IdJornada
        WHERE IdTarea = p_IdTarea;
        
        CALL RegistroHistorial(p_IdUsuario,'update','tareas',p_IdTarea);

        
    END IF;

    -- Retornar la tarea completa
    SELECT 
        t.*,p.Descripcion as Pago, e.Descripcion as Estado
    FROM 
        Tareas t
    INNER JOIN 
        estadostarea e ON e.IdEstadoTarea = t.IdEstadoTarea
    INNER JOIN 
        tipopago p ON p.IdTipoPago = t.IdTipoPago 
	WHERE IdTarea = p_IdTarea;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroTareaAsistencia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroTareaAsistencia`(
    IN p_IdTareaAsistencia INT,
    IN p_IdTarea INT,
    IN p_FAsignacion DATE,
    IN p_IdEmpleado INT,
    IN p_HInicia varchar(5),
    IN p_HTermino varchar(5),
    IN p_IdUsuario INT
)
BEGIN


	delete from tareasempleadosasistencia where IdTarea = p_IdTarea and IdEmpleado=p_IdEmpleado and FechaAsignacion=p_FAsignacion;
	CALL RegistroHistorial(p_IdUsuario,'delete','tareasempleadosasistencia',p_IdTareaAsistencia);
	INSERT INTO tareasempleadosasistencia (IdTarea, IdEmpleado, HoraInicio, HoraTermino, FechaAsignacion)
	VALUES (p_IdTarea,p_IdEmpleado,p_HInicia,p_HTermino,p_FAsignacion);  -- Usar NOW() para fecha y hora actual

	-- Obtener el ID de la nueva tarea
    SET p_IdTareaAsistencia = LAST_INSERT_ID();
    CALL RegistroHistorial(p_IdUsuario,'insert','tareasempleadosasistencia',p_IdTareaAsistencia);


    -- Retornar la tarea completa
    Select * from tareasempleadosasistencia where IdTareaAsistencia=p_IdTareaAsistencia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroTareaRegistro` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroTareaRegistro`(
    IN p_IdTareaEmpleado INT,
    IN p_IdTarea INT,
    IN p_FAsignacion DATE,
    IN p_IdEmpleado INT,
    IN p_Cantidad INT,
    IN p_PagoIndividual DECIMAL(18,2),
    IN p_IdUsuario INT
)
BEGIN


	delete from tareasempleadosregistro where IdTarea = p_IdTarea and IdEmpleado=p_IdEmpleado and FechaAsignacion=p_FAsignacion;
	CALL RegistroHistorial(p_IdUsuario,'delete','tareasempleadosregistro',p_IdTareaEmpleado);
	INSERT INTO tareasempleadosregistro (IdTarea, IdEmpleado, Cantidad, PagoIndividual, FechaAsignacion)
	VALUES (p_IdTarea,p_IdEmpleado,p_Cantidad,p_PagoIndividual,p_FAsignacion);  -- Usar NOW() para fecha y hora actual
	

	-- Obtener el ID de la nueva tarea
    SET p_IdTareaEmpleado = LAST_INSERT_ID();
    CALL RegistroHistorial(p_IdUsuario,'insert','tareasempleadosregistro',p_IdTareaEmpleado);

    -- Retornar la tarea completa
    Select * from tareasempleadosregistro where IdTareaEmpleado=p_IdTareaEmpleado;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroTrabajador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroTrabajador`(
    IN p_IdEmpleado INT,
    IN p_Nombre VARCHAR(100),
    IN p_Apellido VARCHAR(100),
    IN p_RUT VARCHAR(15),
    IN p_Cumplea√±os DATE,
    IN p_Telefono VARCHAR(10),
    IN p_Correo VARCHAR(50),
    IN p_Direccion VARCHAR(200),
    IN p_Ingreso DATE,
    IN p_Estado BIT,
    IN p_IdRol INT,
    IN p_id_empresa INT,
    IN p_idEstadoCivil int,
	IN p_Nacionalidad varchar(45),
    IN p_profesion varchar(45),
    IN p_banco varchar(45),
    IN p_tipocuenta varchar(45),
    IN p_numerocuenta varchar(45),
    IN p_IdSalud int,
    IN p_IdAfp int,
    IN p_IdUsuario INT
)
BEGIN
    -- Si p_IdEmpleado es 0, hacer INSERT
    IF p_IdEmpleado = 0 THEN
        INSERT INTO empleados (Nombre, Apellido, RUT, FechaNacimiento, Telefono, Correo, Direccion, FechaIngreso, Estado, IdRol, IdEmpresa,IdEstadoCivil,Nacionalidad,Profesion,Banco,TipoCuenta,NumeroCuenta,IdSalud,IdAFP)
        VALUES (p_Nombre, p_Apellido, p_RUT, p_Cumplea√±os, p_Telefono, p_Correo, p_Direccion, p_Ingreso, p_Estado, p_IdRol, p_id_empresa,p_idEstadoCivil,p_Nacionalidad,p_profesion,p_banco,p_tipocuenta,p_numerocuenta,p_IdSalud,p_IdAfp);

        -- Obtener el ID del nuevo empleado
        SET p_IdEmpleado = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','empleados',p_IdEmpleado);
    ELSE
        -- Si p_IdEmpleado no es 0, hacer UPDATE
        UPDATE empleados
        SET 
            Nombre = p_Nombre,
            Apellido = p_Apellido,
            RUT = p_RUT,
            FechaNacimiento = p_Cumplea√±os,
            Telefono = p_Telefono,
            Correo = p_Correo,
            Direccion = p_Direccion,
            FechaIngreso = p_Ingreso,
            Estado = p_Estado,
            IdRol = p_IdRol,
            IdEmpresa = p_id_empresa,
            IdEstadoCivil = p_idEstadoCivil,
            Nacionalidad = p_Nacionalidad,
            Profesion = p_profesion,
            Banco = p_banco,
            TipoCuenta = p_tipocuenta,
            NumeroCuenta = p_numerocuenta,
            IdSalud = p_IdSalud,
            IdAFP = p_IdAfp
        WHERE IdEmpleado = p_IdEmpleado;
        
        CALL RegistroHistorial(p_IdUsuario,'update','empleados',p_IdEmpleado);

    END IF;

    -- Retornar el empleado completo
    SELECT * FROM empleados WHERE IdEmpleado = p_IdEmpleado;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroUsuarios` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroUsuarios`(
    IN p_IdUsuario INT,
    IN p_Usuario Varchar(50),
    IN p_Password Varchar(500),
    IN p_IdRol INT,
    IN p_IdEmpresa INT,
    IN p_Estado bit,
    IN p_Nombres varchar(45),
    IN p_Apellidos varchar(45),
    IN p_Rut varchar(12),
    IN p_Correo varchar(45),
    IN p_IdUsuarioIN INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdUsuario = 0 THEN
        INSERT INTO usuarios ( NombreUsuario, Contrase√±a, IdRol, IdEmpresa, FechaCreacion, Estado, Nombres, Apellidos, Rut, Correo)
        VALUES (p_Usuario, p_Password, p_IdRol, p_IdEmpresa, NOW(),p_Estado,p_Nombres,p_Apellidos,p_Rut,p_Correo);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdUsuario = LAST_INSERT_ID();
        
         CALL RegistroHistorial(p_IdUsuarioIN,'insert','usuarios',p_IdUsuario);
    ELSE
        -- Si p_IdTarea no es 0, hacer UPDATE
        UPDATE usuarios
        SET 
            NombreUsuario = p_Usuario,
            IdRol=p_IdRol,
            Estado=p_Estado,
            Nombres=p_Nombres,
            Apellidos=p_Apellidos,
            Rut=p_Rut,
            Correo=p_Correo
        WHERE IdUsuario = p_IdUsuario;
        
        CALL RegistroHistorial(p_IdUsuarioIN,'update','usuarios',p_IdUsuario);

        
    END IF;

    -- Retornar la tarea completa
    SELECT 
        *
    FROM 
        usuarios
	WHERE IdUsuario = p_IdUsuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroUsuariosContrase√±a` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroUsuariosContrase√±a`(
    IN p_IdUsuario INT,
    IN p_Usuario Varchar(50),
    IN p_Password Varchar(500),
    IN p_IdRol INT,
    IN p_IdEmpresa INT,
    IN p_Estado bit,
    IN p_Nombres varchar(45),
    IN p_Apellidos varchar(45),
    IN p_Rut varchar(12),
    IN p_Correo varchar(45),
    IN p_IdUsuarioIN INT
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdUsuario = 0 THEN
        INSERT INTO usuarios ( NombreUsuario, Contrase√±a, IdRol, IdEmpresa, FechaCreacion, Estado, Nombres, Apellidos, Rut, Correo)
        VALUES (p_Usuario, p_Password, p_IdRol, p_IdEmpresa, NOW(),p_Estado,p_Nombres,p_Apellidos,p_Rut,p_Correo);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdUsuario = LAST_INSERT_ID();
         CALL RegistroHistorial(p_IdUsuarioIN,'insert','usuariosC',p_IdUsuario);
    ELSE
        -- Si p_IdTarea no es 0, hacer UPDATE
        UPDATE usuarios
        SET 
            NombreUsuario = p_Usuario,
            IdRol=p_IdRol,
            Estado=p_Estado,
            Nombres=p_Nombres,
            Apellidos=p_Apellidos,
            Rut=p_Rut,
            Correo=p_Correo
        WHERE IdUsuario = p_IdUsuario;
        
        CALL RegistroHistorial(p_IdUsuarioIN,'update','usuariosC',p_IdUsuario);

        
    END IF;

    -- Retornar la tarea completa
    SELECT 
        *
    FROM 
        usuarios
	WHERE IdUsuario = p_IdUsuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroVacaciones` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistroVacaciones`(
    IN p_IdVacaciones INT,
    IN p_IdEmpleado INT,
    IN p_FInicio DATE,
    IN p_FTermino DATE,
    IN p_Cant INT,
    IN p_Saldo INT,
    IN p_IdUsuario INT,
    IN p_IdEmpresa INT,
    IN p_FRetorno DATE
)
BEGIN
    -- Si p_IdTarea es 0, hacer INSERT
    IF p_IdVacaciones = 0 THEN
        INSERT INTO vacaciones (IdEmpleado, FechaIni, FechaFin, CantDias, SaldoTrabajador, FechaRegistro, Usuario,IdEmpresa,Fecha_Retorno)
        VALUES (p_IdEmpleado, p_FInicio, p_FTermino, p_Cant, p_Saldo, NOW(),p_IdUsuario,p_IdEmpresa,p_FRetorno);  -- Usar NOW() para fecha y hora actual

        -- Obtener el ID de la nueva tarea
        SET p_IdVacaciones = LAST_INSERT_ID();
        
        CALL RegistroHistorial(p_IdUsuario,'insert','vacaciones',p_IdVacaciones);

    ELSE
        -- Si p_IdTarea no es 0, hacer UPDATE
        UPDATE vacaciones
        SET 
            FechaIni = p_FInicio,
            FechaFin = p_FTermino,
            CantDias = p_Cant,
            SaldoTrabajador = p_Saldo,
            Usuario = p_IdUsuario,
            Fecha_Retorno = p_FRetorno
        WHERE idVacaciones = p_IdVacaciones;
        
        CALL RegistroHistorial(p_IdUsuario,'update','vacaciones',p_IdVacaciones);

        
    END IF;

    -- Retornar la tarea completa
    SELECT 
        *
    FROM 
        vacaciones
	WHERE idVacaciones = p_IdVacaciones;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ResetPassUsuarios` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ResetPassUsuarios`(in p_Id_Usuario int,in p_password Varchar(255))
BEGIN
    update usuarios set Contrase√±a= p_password where IdUsuario=p_Id_Usuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_ComparacionSueldosBonos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ComparacionSueldosBonos`(
    IN p_IdEmpresa INT
)
BEGIN
    -- Sueldos base y bonificaciones desde liquidaciones del mes actual
    SELECT 
        e.IdEmpleado,
        CONCAT(e.Nombre, ' ', e.Apellido) AS Empleado,
        SUM(l.SalarioBase) AS SueldoBase,
        SUM(l.Bonificaciones) AS Bonos
    FROM liquidaciones l
    INNER JOIN empleados e ON e.IdEmpleado = l.IdEmpleado
    WHERE l.IdEmpresa = p_IdEmpresa
      AND l.year = YEAR(CURDATE())
      AND l.month = MONTH(CURDATE())
    GROUP BY e.IdEmpleado, Empleado
    ORDER BY Empleado;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_DistribucionCostosLaboralesUltimoMes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DistribucionCostosLaboralesUltimoMes`(IN p_IdEmpresa INT)
BEGIN
    DECLARE v_year INT;
    DECLARE v_month INT;

    -- Obtener el √∫ltimo a√±o y mes de las liquidaciones
    SELECT MAX(year), MAX(month)
    INTO v_year, v_month
    FROM liquidaciones
    WHERE IdEmpresa = p_IdEmpresa;

    -- Tabla temporal para los resultados
    CREATE TEMPORARY TABLE IF NOT EXISTS DistribucionCostos (
        Concepto VARCHAR(100),
        MontoTotal DECIMAL(18,2)
    );

    -- Sueldos base
    INSERT INTO DistribucionCostos (Concepto, MontoTotal)
    SELECT 'Sueldos Base', SUM(SalarioBase)
    FROM liquidaciones
    WHERE IdEmpresa = p_IdEmpresa AND year = v_year AND month = v_month;

    -- Bonificaciones (en liquidaciones)
    INSERT INTO DistribucionCostos (Concepto, MontoTotal)
    SELECT 'Bonificaciones (Liquidaciones)', SUM(Bonificaciones)
    FROM liquidaciones
    WHERE IdEmpresa = p_IdEmpresa AND year = v_year AND month = v_month;

    -- Bonificaciones externas (filtradas por mes y a√±o de aplicaci√≥n)
    INSERT INTO DistribucionCostos (Concepto, MontoTotal)
    SELECT 'Bonificaciones (Extras)', SUM(b.Monto)
    FROM bonificaciones b
    JOIN bonificacionesempleados be ON b.IdBonificacion = be.IdBonificacion
    WHERE b.IdEmpresa = p_IdEmpresa
      AND b.Estado = 1
      AND be.Estado = 1
      AND YEAR(b.FechaAplicacion) = v_year
      AND MONTH(b.FechaAplicacion) = v_month;

    -- Deducciones (en liquidaciones)
    INSERT INTO DistribucionCostos (Concepto, MontoTotal)
    SELECT 'Deducciones (Liquidaciones)', SUM(Deducciones)
    FROM liquidaciones
    WHERE IdEmpresa = p_IdEmpresa AND year = v_year AND month = v_month;

    -- Deducciones externas (por mes y a√±o)
    INSERT INTO DistribucionCostos (Concepto, MontoTotal)
    SELECT 'Deducciones (Extras)', SUM(d.Monto)
    FROM deducciones d
    JOIN deduccionesempleados de ON d.IdDeduccion = de.IdDeduccion
    WHERE d.IdEmpresa = p_IdEmpresa
      AND d.Estado = 1
      AND de.Estado = 1
      AND YEAR(d.FechaAplicacion) = v_year
      AND MONTH(d.FechaAplicacion) = v_month;

    -- Finiquitos (por fecha de finiquito)
    INSERT INTO DistribucionCostos (Concepto, MontoTotal)
    SELECT 'Finiquitos', IFNULL(SUM(fd.Monto),0)
    FROM finiquitos f
    JOIN finiquitodetalle fd ON f.idFiniquitos = fd.IdFiniquito
    WHERE f.IdEmpresa = p_IdEmpresa
      AND f.Estado = 1
      AND YEAR(f.FechaFiniquito) = v_year
      AND MONTH(f.FechaFiniquito) = v_month;

    -- Resultado
    SELECT Concepto, MontoTotal
    FROM DistribucionCostos
    ORDER BY MontoTotal DESC;

    -- Limpieza
    DROP TEMPORARY TABLE IF EXISTS DistribucionCostos;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-02 21:44:20
