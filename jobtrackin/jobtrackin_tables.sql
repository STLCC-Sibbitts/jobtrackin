SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


CREATE TABLE IF NOT EXISTS `jobActions` (
  `actionID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `companyId` bigint(20) NOT NULL,
  `contactID` bigint(20) DEFAULT NULL,
  `appFilled` tinyint(1) NOT NULL,
  `resInPerson` tinyint(1) NOT NULL,
  `resFaxed` tinyint(1) NOT NULL,
  `resEmailed` tinyint(1) NOT NULL,
  `resEmailContID` int(11) NOT NULL,
  PRIMARY KEY (`actionID`),
  UNIQUE KEY `actionID` (`actionID`),
  KEY `companyId` (`companyId`),
  KEY `contactID` (`contactID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `jobCallLog` (
  `callLogID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `callCompanyID` bigint(20) NOT NULL,
  `userID` bigint(20) NOT NULL,
  `contactID` bigint(20) NOT NULL,
  `callLogDate` date NOT NULL,
  `callLogTime` time NOT NULL,
  `callLogSpokeTo` varchar(255) COLLATE utf8_bin NOT NULL,
  `callLogLeftMsg` tinyint(1) NOT NULL,
  `callFollowUpDate` date NOT NULL,
  `callFollowUpTime` time NOT NULL,
  `callLogComments` blob NOT NULL,
  PRIMARY KEY (`callLogID`),
  UNIQUE KEY `callLogID` (`callLogID`),
  KEY `callCompanyID` (`callCompanyID`,`callLogDate`,`callFollowUpDate`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

CREATE TABLE IF NOT EXISTS `jobCompanies` (
  `companyId` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `companyName` varchar(255) COLLATE utf8_bin NOT NULL,
  `companyStr` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `companySte` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `companyCty` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  `companyState` varchar(2) COLLATE utf8_bin DEFAULT NULL,
  `companyZip5` varchar(5) COLLATE utf8_bin DEFAULT NULL,
  `companyPh` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  `companyUrl` varchar(25) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`companyId`),
  KEY `userID` (`userID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

CREATE TABLE IF NOT EXISTS `jobContact` (
  `contactID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `companyID` bigint(20) NOT NULL,
  `contactName` varchar(255) COLLATE utf8_bin NOT NULL,
  `contactTitle` varchar(50) COLLATE utf8_bin NOT NULL,
  `contactEmail` varchar(255) COLLATE utf8_bin NOT NULL,
  `contactComments` blob NOT NULL,
  PRIMARY KEY (`contactID`),
  UNIQUE KEY `contactID` (`contactID`),
  KEY `companyID` (`companyID`),
  KEY `contactName` (`contactName`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

CREATE TABLE IF NOT EXISTS `jobDates` (
  `dateID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `contactID` bigint(20) NOT NULL,
  `contactDate` date NOT NULL,
  `contactTime` time NOT NULL,
  `followupDate` date NOT NULL,
  `followupTime` time DEFAULT NULL,
  PRIMARY KEY (`dateID`),
  UNIQUE KEY `dateID` (`dateID`),
  KEY `contactDate` (`contactDate`,`followupDate`),
  KEY `followupTime` (`followupTime`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

CREATE TABLE IF NOT EXISTS `jobInterviews` (
  `interviewID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `interviewCompanyID` bigint(20) NOT NULL,
  `interviewDate` date NOT NULL,
  `interviewTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `interviewCompleted` tinyint(1) NOT NULL,
  `interviewComments` blob NOT NULL,
  PRIMARY KEY (`interviewID`),
  UNIQUE KEY `interviewID` (`interviewID`),
  KEY `interviewDate` (`interviewDate`,`interviewCompleted`),
  KEY `interviewCompanyID` (`interviewCompanyID`),
  KEY `userID` (`userID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=2 ;

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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
