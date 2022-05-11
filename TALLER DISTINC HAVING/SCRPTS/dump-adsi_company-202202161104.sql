-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: adsi_company
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.21-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `area`
--

DROP TABLE IF EXISTS `area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `area` (
  `NumeroArea` int(11) unsigned NOT NULL,
  `NombreArea` varchar(50) NOT NULL,
  PRIMARY KEY (`NumeroArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` VALUES (1,'Dirección'),(2,'Ventas'),(3,'Investigación'),(4,'Sistemas');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dependiente`
--

DROP TABLE IF EXISTS `dependiente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dependiente` (
  `CedulaDependiente` varchar(11) NOT NULL,
  `NombreDependiente` varchar(60) NOT NULL,
  `Sexo` char(1) DEFAULT NULL,
  `FechaNacimiento` date NOT NULL,
  `Parentesco` varchar(50) NOT NULL,
  `Fk_CedulaEmpleado` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`CedulaDependiente`),
  KEY `Fk_CedulaEmpleado` (`Fk_CedulaEmpleado`),
  CONSTRAINT `dependiente_ibfk_1` FOREIGN KEY (`Fk_CedulaEmpleado`) REFERENCES `empleado` (`CedulaEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dependiente`
--

LOCK TABLES `dependiente` WRITE;
/*!40000 ALTER TABLE `dependiente` DISABLE KEYS */;
INSERT INTO `dependiente` VALUES ('1111','Alicia','F','1988-04-05','HIJA','333445555'),('2222','Teodoro','M','1983-10-25','HIJO','333445555'),('3333','Monica','F','1978-05-03','ESPOSA','333445555'),('4444','Braulio','M','1988-02-28','ESPOSO','987654321'),('5555','Michael','M','1988-06-04','SOBRINO','123456789'),('6666','Petronila','F','1987-12-31','HIJA','123456789'),('7777','Elizabeth','F','1978-08-10','ESPOSA','123456789'),('8888','Andrea','M','2011-07-14','HIJO','888775555');
/*!40000 ALTER TABLE `dependiente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `CedulaEmpleado` varchar(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `FechaNacimiento` date NOT NULL,
  `FechaIngreso` date NOT NULL,
  `Direccion` varchar(50) DEFAULT NULL,
  `Salario` float DEFAULT NULL,
  `AnnosExperiencia` int(11) DEFAULT NULL,
  `Activo` tinyint(4) DEFAULT NULL,
  `Sexo` char(1) DEFAULT NULL,
  `FK_NumeroArea` int(11) unsigned NOT NULL,
  PRIMARY KEY (`CedulaEmpleado`),
  KEY `FK_NumeroArea` (`FK_NumeroArea`),
  CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`FK_NumeroArea`) REFERENCES `area` (`NumeroArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('123456780','DANIELA','PEREZ','1975-07-20','2001-04-25','CRRA 12 14-19',1000000,2,1,'F',3),('123456789','DANIEL','MEJIA','1980-02-04','2010-02-02',NULL,2000000,3,1,'M',2),('304156911','CAROL','GARCIA','1979-11-05','2010-11-19','CRRA 11 7-25',1500000,2,1,'F',2),('333445555','PEDRO','ALVAREZ','1989-02-28','2002-10-09','CRRA 12 14-19',5000000,15,0,'M',2),('549751072','RAMON','VALDEZ','1988-09-17','2000-01-13',NULL,1500000,17,1,'M',2),('666884444','DIEGO','OROZCO','1985-09-12','2011-09-12','CRRA 12 14-19',1500000,1,0,'M',2),('888775555','MARIA JOSE','OSORIO','1981-10-12','1998-07-15',NULL,9000000,7,1,'F',1),('987654321','DUVAN','VELEZ','1979-01-22','2009-08-14','CRRA 12 14-19',900000,1,0,'M',4),('999887777','PABLO','DIAZ','1972-08-14','2003-01-01','CRRA 12 14-19',4000000,10,0,'M',3);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado_proyecto`
--

DROP TABLE IF EXISTS `empleado_proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado_proyecto` (
  `Fk_CedulaEmpleado` varchar(11) NOT NULL,
  `FK_NumeroProyecto` int(11) unsigned NOT NULL,
  `HorasTrabajadas` float DEFAULT NULL,
  `FechaTrabajo` datetime DEFAULT NULL,
  PRIMARY KEY (`Fk_CedulaEmpleado`,`FK_NumeroProyecto`),
  KEY `FK_NumeroProyecto` (`FK_NumeroProyecto`),
  CONSTRAINT `empleado_proyecto_ibfk_1` FOREIGN KEY (`Fk_CedulaEmpleado`) REFERENCES `empleado` (`CedulaEmpleado`),
  CONSTRAINT `empleado_proyecto_ibfk_2` FOREIGN KEY (`FK_NumeroProyecto`) REFERENCES `proyecto` (`NumeroProyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado_proyecto`
--

LOCK TABLES `empleado_proyecto` WRITE;
/*!40000 ALTER TABLE `empleado_proyecto` DISABLE KEYS */;
INSERT INTO `empleado_proyecto` VALUES ('123456789',1,32.5,'2015-10-12 08:40:00'),('123456789',2,7.5,'2015-10-12 15:35:00'),('304156911',10,35,'2015-10-16 20:00:00'),('304156911',30,5,'2015-04-17 13:43:00'),('333445555',2,10,'2015-04-10 09:27:00'),('333445555',3,10,'2015-10-12 07:50:00'),('333445555',10,10,'1988-04-12 12:03:00'),('333445555',20,10,'2015-10-12 09:13:00'),('549751072',1,20,'2015-10-02 00:00:00'),('549751072',2,20,'2015-04-09 19:12:00'),('666884444',3,20,'2015-10-01 00:00:00'),('888775555',20,12.6,'2015-04-20 16:10:00'),('987654321',20,15,'2015-04-19 00:00:00'),('987654321',30,20,'2015-04-18 11:13:00'),('999887777',10,10,'2015-10-13 21:12:00'),('999887777',30,30,'2015-10-12 18:05:00');
/*!40000 ALTER TABLE `empleado_proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jefe`
--

DROP TABLE IF EXISTS `jefe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jefe` (
  `Fk_NumeroArea` int(11) unsigned NOT NULL,
  `Fk_Cedulaempleado` varchar(11) NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaFin` date DEFAULT NULL,
  `Estado` varchar(15) NOT NULL,
  PRIMARY KEY (`Fk_NumeroArea`,`Fk_Cedulaempleado`),
  KEY `Fk_Cedulaempleado` (`Fk_Cedulaempleado`),
  CONSTRAINT `jefe_ibfk_1` FOREIGN KEY (`Fk_NumeroArea`) REFERENCES `area` (`NumeroArea`),
  CONSTRAINT `jefe_ibfk_2` FOREIGN KEY (`Fk_Cedulaempleado`) REFERENCES `empleado` (`CedulaEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jefe`
--

LOCK TABLES `jefe` WRITE;
/*!40000 ALTER TABLE `jefe` DISABLE KEYS */;
INSERT INTO `jefe` VALUES (1,'888775555','1998-07-15',NULL,'activo'),(2,'123456789','2000-01-01','2012-09-09','inactivo'),(2,'333445555','2002-10-09',NULL,'activo'),(3,'999887777','2003-01-01',NULL,'activo');
/*!40000 ALTER TABLE `jefe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `NumeroProducto` int(11) unsigned NOT NULL,
  `Descripcion` varchar(350) DEFAULT NULL,
  `PrecioActual` float unsigned NOT NULL,
  PRIMARY KEY (`NumeroProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Mouse',50000),(2,'SSD 4 Teras',550000),(3,'Teclado Mecanico',295000),(4,'Cable HDMI',35000),(5,'Memoria Ram 16 Gb',545000),(6,'Soporte Pared Monitor',135000),(7,'Kit Limpieza Accesorios',21000),(8,'Estabilizador',72000),(9,'Base Refrigerante',85000),(10,'Parlantes',60000),(11,'Usb 64 Gb',45000);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proyecto`
--

DROP TABLE IF EXISTS `proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proyecto` (
  `NumeroProyecto` int(10) unsigned NOT NULL,
  `NombreProyecto` varchar(50) NOT NULL,
  `Descripcion` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`NumeroProyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proyecto`
--

LOCK TABLES `proyecto` WRITE;
/*!40000 ALTER TABLE `proyecto` DISABLE KEYS */;
INSERT INTO `proyecto` VALUES (1,'Econo','PROYECTO economia'),(2,'Erp','Implementación erp'),(3,'Diagnostico','Diagnostico de ventas'),(10,'Automatización','Automatización de procesos'),(20,'Reorganización','Reorganización de dependencias'),(30,'Nuevos valores','Nuevos valores artículos');
/*!40000 ALTER TABLE `proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `venta` (
  `NumeroVenta` int(11) unsigned NOT NULL,
  `FechaVenta` date NOT NULL,
  `Fk_CedulaEmpleado` varchar(11) NOT NULL,
  PRIMARY KEY (`NumeroVenta`),
  KEY `Fk_CedulaEmpleado` (`Fk_CedulaEmpleado`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`Fk_CedulaEmpleado`) REFERENCES `empleado` (`CedulaEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,'2015-10-30','123456789'),(2,'2015-10-19','123456789'),(3,'2015-10-20','123456789'),(4,'2015-10-10','123456789'),(5,'2015-10-03','123456789'),(6,'2015-10-02','123456789'),(7,'2015-10-22','549751072'),(8,'2015-10-20','549751072'),(9,'2015-10-20','549751072'),(10,'2015-10-14','304156911'),(11,'2015-10-24','304156911'),(12,'2015-10-08','304156911'),(13,'2015-10-06','304156911'),(14,'2015-10-26','333445555'),(15,'2015-10-15','333445555'),(16,'2015-10-30','666884444'),(17,'2015-10-28','666884444'),(18,'2015-10-28','666884444'),(19,'2015-10-22','666884444'),(20,'2015-10-20','666884444'),(21,'2015-10-16','666884444'),(22,'2015-10-07','666884444'),(23,'2015-10-01','666884444');
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta_producto`
--

DROP TABLE IF EXISTS `venta_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `venta_producto` (
  `Fk_NumeroVenta` int(11) unsigned NOT NULL,
  `Fk_NumeroProducto` int(11) unsigned NOT NULL,
  `Cantidad` int(11) unsigned NOT NULL,
  `PrecioUnitario` float NOT NULL,
  PRIMARY KEY (`Fk_NumeroVenta`,`Fk_NumeroProducto`),
  KEY `Fk_NumeroProducto` (`Fk_NumeroProducto`),
  CONSTRAINT `venta_producto_ibfk_1` FOREIGN KEY (`Fk_NumeroVenta`) REFERENCES `venta` (`NumeroVenta`),
  CONSTRAINT `venta_producto_ibfk_2` FOREIGN KEY (`Fk_NumeroProducto`) REFERENCES `producto` (`NumeroProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta_producto`
--

LOCK TABLES `venta_producto` WRITE;
/*!40000 ALTER TABLE `venta_producto` DISABLE KEYS */;
INSERT INTO `venta_producto` VALUES (1,1,7,50000),(1,2,1,550000),(1,10,5,60000),(2,11,1,45000),(3,1,2,50000),(4,2,5,550000),(5,3,3,295000),(6,8,1,72000),(6,9,6,85000),(6,10,1,60000),(7,10,4,60000),(8,11,2,45000),(9,4,5,35000),(9,5,1,545000),(10,6,2,135000),(10,7,11,21000),(11,7,20,21000),(12,3,1,295000),(13,3,1,295000),(14,3,1,295000),(14,10,5,60000),(15,10,2,60000),(16,2,4,550000),(16,3,1,295000),(17,9,11,85000),(17,10,9,60000),(18,10,8,60000),(19,6,7,135000),(19,7,2,21000),(19,8,5,72000),(20,4,10,35000),(21,5,3,545000),(22,11,1,45000),(23,1,2,50000),(23,2,9,550000),(23,3,1,295000),(23,4,5,35000);
/*!40000 ALTER TABLE `venta_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'adsi_company'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-16 11:04:26
