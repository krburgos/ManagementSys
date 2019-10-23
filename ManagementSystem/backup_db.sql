/*
SQLyog Community v12.4.3 (64 bit)
MySQL - 5.5.35 : Database - DbTest
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`DbTest` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `DbTest`;

/*Table structure for table `Patients` */

DROP TABLE IF EXISTS `Patients`;

CREATE TABLE `Patients` (
  `PatientID` int(10) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(20) NOT NULL,
  `MiddleName` varchar(20) NOT NULL,
  `LastName` varchar(20) NOT NULL,
  `PatientAddress` varchar(100) NOT NULL,
  `CivilStatus` varchar(20) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Age` int(10) NOT NULL,
  `DateAdded` date NOT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `Patients` */

insert  into `Patients`(`PatientID`,`FirstName`,`MiddleName`,`LastName`,`PatientAddress`,`CivilStatus`,`Gender`,`Age`,`DateAdded`) values 
(1,'Test','Me','Please','test','Single','Male',21,'2019-10-15'),
(2,'John','G','Smith','Cebu City','Divorced','Male',22,'2019-10-15'),
(3,'abc','abc','abc','abc','Single','Male',12,'2019-10-15'),
(5,'Jeep','Nonits','Hsieh','Scc','Single','Female',18,'2019-10-15'),
(6,'Raymart','Hehe','Cabili','Scc','Single','Male',18,'2019-10-16'),
(7,'Judelyn','Tambok','Mapa','Scc','Single','Female',20,'2019-10-17'),
(8,'Judelyn','Mapa','Cabili','scc','Married','Female',18,'2019-10-17'),
(9,'Jude ','Bok','Mapa','scc','Single','Female',18,'2019-10-17');

/*Table structure for table `Products` */

DROP TABLE IF EXISTS `Products`;

CREATE TABLE `Products` (
  `ProductID` int(10) NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(50) NOT NULL,
  `ProductDesc` varchar(50) NOT NULL,
  `Supplier` varchar(20) DEFAULT NULL,
  `SupplierPrice` decimal(20,0) DEFAULT NULL,
  `StorePrice` decimal(20,0) DEFAULT NULL,
  `Qty` int(20) DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `Products` */

/*Table structure for table `Services` */

DROP TABLE IF EXISTS `Services`;

CREATE TABLE `Services` (
  `ServiceID` int(10) NOT NULL AUTO_INCREMENT,
  `ServiceName` varchar(20) NOT NULL,
  `ServiceDesc` varchar(50) NOT NULL,
  `ServicePrice` decimal(10,0) NOT NULL,
  PRIMARY KEY (`ServiceID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `Services` */

/*Table structure for table `Suppliers` */

DROP TABLE IF EXISTS `Suppliers`;

CREATE TABLE `Suppliers` (
  `SupplierID` int(10) NOT NULL AUTO_INCREMENT,
  `SupplierName` varchar(50) NOT NULL,
  `SupplierContact` varchar(50) NOT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `Suppliers` */

insert  into `Suppliers`(`SupplierID`,`SupplierName`,`SupplierContact`) values 
(1,'Apins','0347295901'),
(2,'Pure Gold','099990001');

/*Table structure for table `Visits` */

DROP TABLE IF EXISTS `Visits`;

CREATE TABLE `Visits` (
  `VisitID` int(10) NOT NULL AUTO_INCREMENT,
  `PID` int(10) NOT NULL,
  `Findings` varchar(500) NOT NULL,
  `Treatment` varchar(500) NOT NULL,
  `DateCreated` date NOT NULL,
  PRIMARY KEY (`VisitID`,`PID`),
  KEY `PID` (`PID`),
  CONSTRAINT `Visits_ibfk_1` FOREIGN KEY (`PID`) REFERENCES `Patients` (`PatientID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `Visits` */

insert  into `Visits`(`VisitID`,`PID`,`Findings`,`Treatment`,`DateCreated`) values 
(3,1,'test2','test2','2019-10-16'),
(4,1,'test23','test23','2019-10-16'),
(5,2,'testasdfas','testasdfasdf','2019-10-16'),
(6,2,'asdfasdf','asdfasdfa','2019-10-16'),
(7,7,'Tambok','Lamingon','2019-10-17'),
(8,8,'ew','Badot','2019-10-17'),
(9,9,'tambok','badot','2019-10-17');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
