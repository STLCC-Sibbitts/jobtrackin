SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


CREATE TABLE IF NOT EXISTS `jobActivity` (
  `activityID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `companyID` bigint(20) NOT NULL,
  `userID` bigint(20) NOT NULL,
  `contactID` bigint(20) NOT NULL,
  `contactDate` date NOT NULL,
  `contactTime` time NOT NULL,
  `activitySpokeTo` varchar(255) COLLATE utf8_bin NOT NULL,
  `activityLeftMsg` tinyint(1) NOT NULL,
  `followUpDate` date NOT NULL,
  `followUpTime` time NOT NULL,
  `appOnline` tinyint(1) DEFAULT NULL,
  `appOnsite` tinyint(1) DEFAULT NULL,
  `resOnsite` tinyint(1) DEFAULT NULL,
  `resFaxed` tinyint(1) DEFAULT NULL,
  `resEmailed` tinyint(1) DEFAULT NULL,
  `resEmailedTo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `positionOpen` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `activityComments` blob NOT NULL,
  PRIMARY KEY (`activityID`),
  UNIQUE KEY `activityID` (`activityID`),
  KEY `companyID` (`companyID`,`contactDate`,`followUpDate`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

INSERT INTO `jobActivity` (`activityID`, `companyID`, `userID`, `contactID`, `contactDate`, `contactTime`, `activitySpokeTo`, `activityLeftMsg`, `followUpDate`, `followUpTime`, `appOnline`, `appOnsite`, `resOnsite`, `resFaxed`, `resEmailed`, `resEmailedTo`, `positionOpen`, `activityComments`) VALUES
(1, 1, 1, 1, '2014-05-30', '09:30:00', 'Jose Conseco', 0, '2014-06-10', '16:25:00', 0, 0, 0, 0, 1, 'Jose Conseco', 'Web Developer', '');

CREATE TABLE IF NOT EXISTS `jobCompanies` (
  `companyID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `companyName` varchar(255) COLLATE utf8_bin NOT NULL,
  `companyStr` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `companySte` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `companyCty` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  `companyState` varchar(2) COLLATE utf8_bin DEFAULT NULL,
  `companyZip5` varchar(5) COLLATE utf8_bin DEFAULT NULL,
  `companyPh` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  `companyUrl` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`companyID`),
  KEY `userID` (`userID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

INSERT INTO `jobCompanies` (`companyID`, `userID`, `companyName`, `companyStr`, `companySte`, `companyCty`, `companyState`, `companyZip5`, `companyPh`, `companyUrl`) VALUES
(1, 1, 'Company One Technologies', '5525 Somewhere Pl', '2304', 'Saskatchewan', 'AK', '28546', '555-555-1212', 'http://www.nowhere.com');

CREATE TABLE IF NOT EXISTS `jobContact` (
  `contactID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `companyID` bigint(20) NOT NULL,
  `contactName` varchar(255) COLLATE utf8_bin NOT NULL,
  `contactTitle` varchar(50) COLLATE utf8_bin NOT NULL,
  `contactPhone` varchar(12) COLLATE utf8_bin DEFAULT NULL,
  `contactEmail` varchar(255) COLLATE utf8_bin NOT NULL,
  `contactComments` blob NOT NULL,
  PRIMARY KEY (`contactID`),
  UNIQUE KEY `contactID` (`contactID`),
  KEY `companyID` (`companyID`),
  KEY `contactName` (`contactName`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

INSERT INTO `jobContact` (`contactID`, `userID`, `companyID`, `contactName`, `contactTitle`, `contactPhone`, `contactEmail`, `contactComments`) VALUES
(1, 1, 1, 'Jose Conseco', 'Janitor', '555-555-1212', 'jconseco@cotech.com', '');

CREATE TABLE IF NOT EXISTS `jobInterviews` (
  `interviewID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `companyID` bigint(20) NOT NULL,
  `interviewDate` date NOT NULL,
  `interviewTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `interviewCompleted` tinyint(1) NOT NULL,
  `interviewComments` blob NOT NULL,
  PRIMARY KEY (`interviewID`),
  UNIQUE KEY `interviewID` (`interviewID`),
  KEY `interviewDate` (`interviewDate`,`interviewCompleted`),
  KEY `interviewCompanyID` (`companyID`),
  KEY `userID` (`userID`),
  KEY `userID_2` (`userID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

INSERT INTO `jobInterviews` (`interviewID`, `userID`, `companyID`, `interviewDate`, `interviewTime`, `interviewCompleted`, `interviewComments`) VALUES
(1, 1, 1, '2014-04-08', '2014-04-08 09:30:00', 0, '');

CREATE TABLE IF NOT EXISTS `jobPosition` (
  `jobID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `companyID` bigint(20) NOT NULL,
  `contactID` bigint(20) NOT NULL,
  `jobTitleDesc` varchar(255) COLLATE utf8_bin NOT NULL,
  `jobCoName` varchar(255) COLLATE utf8_bin NOT NULL,
  `jobCoStreet` varchar(255) COLLATE utf8_bin NOT NULL,
  `jobCoCity` varchar(50) COLLATE utf8_bin NOT NULL,
  `jobState` varchar(2) COLLATE utf8_bin NOT NULL,
  `jobCoZip` varchar(5) COLLATE utf8_bin NOT NULL,
  `jobCoZip4` varchar(2) COLLATE utf8_bin NOT NULL,
  `jobPhone` varchar(10) COLLATE utf8_bin NOT NULL,
  `jobWebsite` varchar(255) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`jobID`),
  UNIQUE KEY `jobID` (`jobID`),
  KEY `jobCoCity` (`jobCoCity`,`jobState`),
  KEY `jobCoName` (`jobCoName`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

INSERT INTO `jobPosition` (`jobID`, `userID`, `companyID`, `contactID`, `jobTitleDesc`, `jobCoName`, `jobCoStreet`, `jobCoCity`, `jobState`, `jobCoZip`, `jobCoZip4`, `jobPhone`, `jobWebsite`) VALUES
(1, 1, 1, 1, 'Web Developer', 'Company One Technologies', '5525 Somewhere Pl, Ste 2304', 'Saskatchewan', 'AK', '28546', '', '555-555-12', 'http://www.nowhere.com');

CREATE TABLE IF NOT EXISTS `jobUsers` (
  `userID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(15) COLLATE utf8_bin NOT NULL,
  `password` varchar(15) COLLATE utf8_bin NOT NULL,
  `firstName` varchar(15) COLLATE utf8_bin NOT NULL,
  `lastName` varchar(15) COLLATE utf8_bin NOT NULL,
  `socLastFour` int(4) NOT NULL,
  `email` varchar(100) COLLATE utf8_bin NOT NULL,
  `photoPath` varchar(255) COLLATE utf8_bin DEFAULT '""',
  `resumePath` varchar(255) COLLATE utf8_bin DEFAULT '""',
  `permission` varchar(5) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`userID`),
  UNIQUE KEY `userID` (`userID`),
  KEY `username` (`username`),
  KEY `firstName` (`firstName`,`lastName`,`permission`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=3 ;

INSERT INTO `jobUsers` (`userID`, `username`, `password`, `firstName`, `lastName`, `socLastFour`, `email`, `photoPath`, `resumePath`, `permission`) VALUES
(1, 'matt', 'Spectacu1ar', 'Matt', 'Gagne', 2878, 'mgstlcc@gmail.com', ' ', ' ', 'admin');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
