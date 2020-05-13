-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 08, 2020 at 03:05 PM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `managerdatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `drivers`
--

CREATE TABLE `drivers` (
  `Id` int(11) UNSIGNED NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Surname` varchar(100) NOT NULL,
  `Fathername` varchar(100) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Salary` int(11) NOT NULL,
  `Login` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `drivers`
--

INSERT INTO `drivers` (`Id`, `Name`, `Surname`, `Fathername`, `Category`, `Salary`, `Login`) VALUES
(3, 'сережа', 'нуачё', 'почему', 'пиво', 2, 'heae');

-- --------------------------------------------------------

--
-- Table structure for table `transport`
--

CREATE TABLE `transport` (
  `Id` int(11) UNSIGNED NOT NULL,
  `Type` varchar(100) NOT NULL,
  `Consumption` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `transport`
--

INSERT INTO `transport` (`Id`, `Type`, `Consumption`) VALUES
(5, 'грузовушка', 22),
(6, 'просто', 123),
(7, 'грузовушка-легковушка', 22221321),
(8, '13131', 1313);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Login` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Role` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Login`, `Password`, `Role`) VALUES
(1, 'igor', '1234', 2),
(5, 'sergey228', '123', 0),
(8, '312321', '213', 2),
(16, 'le2l', '123', 2),
(23, 'lel', '123', 1),
(14, '1111aaa', '213', 2),
(25, 'le222l', '123', 1),
(24, 'l332el', '123313113', 1),
(19, 'l1el', '123', 2),
(20, 'heae', '123', 0),
(26, 'heheeh', 'heheehe', 1),
(22, '123123', '123123', 1),
(27, 'adsdsaads', 'adasddasdas', 2);

-- --------------------------------------------------------

--
-- Table structure for table `waybills`
--

CREATE TABLE `waybills` (
  `Id` int(11) UNSIGNED NOT NULL,
  `DriverId` int(11) NOT NULL,
  `TransportId` int(11) NOT NULL,
  `Distance` varchar(100) NOT NULL,
  `Price` int(11) NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `waybills`
--

INSERT INTO `waybills` (`Id`, `DriverId`, `TransportId`, `Distance`, `Price`, `Date`) VALUES
(4, 3, 5, '12331', 312, '04.05.2020');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `drivers`
--
ALTER TABLE `drivers`
  ADD UNIQUE KEY `Id` (`Id`);

--
-- Indexes for table `transport`
--
ALTER TABLE `transport`
  ADD UNIQUE KEY `Id` (`Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `Id` (`Id`);

--
-- Indexes for table `waybills`
--
ALTER TABLE `waybills`
  ADD UNIQUE KEY `Id` (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `drivers`
--
ALTER TABLE `drivers`
  MODIFY `Id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `transport`
--
ALTER TABLE `transport`
  MODIFY `Id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `waybills`
--
ALTER TABLE `waybills`
  MODIFY `Id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
