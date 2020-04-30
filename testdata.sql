-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 28, 2020 at 08:15 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testdata`
--

-- --------------------------------------------------------

--
-- Table structure for table `basket`
--

CREATE TABLE `basket` (
  `ProductID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `basket`
--

INSERT INTO `basket` (`ProductID`, `Quantity`) VALUES
(614021, 1),
(614008, 1),
(614021, 1);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') COLLATE utf8_unicode_ci NOT NULL,
  `CustomerType` enum('Member','VIP','Other') COLLATE utf8_unicode_ci NOT NULL,
  `CustomerTelNo` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `CustomerName`, `Gender`, `CustomerType`, `CustomerTelNo`) VALUES
(123456, 'Don\'t have', '', '', '-'),
(178265, ' chan', 'M', 'VIP', '0945301033'),
(337215, 'วรายุทธ', 'M', 'VIP', '0657706835'),
(509122, ' chan3', 'M', 'VIP', '0945301033'),
(614002, 'Arista', 'F', 'VIP', '0657706836'),
(614008, 'Athena', 'F', 'Member', '0981256444'),
(614098, 'Alice', 'F', 'VIP', '0657706837');

-- --------------------------------------------------------

--
-- Table structure for table `from_save`
--

CREATE TABLE `from_save` (
  `formid` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `login_save`
--

CREATE TABLE `login_save` (
  `staffsID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `mamory`
--

CREATE TABLE `mamory` (
  `proid` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `mamory`
--

INSERT INTO `mamory` (`proid`) VALUES
(0);

-- --------------------------------------------------------

--
-- Table structure for table `memorymenber`
--

CREATE TABLE `memorymenber` (
  `medid` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `ProductName`, `Price`, `ProductDetail`) VALUES
(614001, 'LATTE', 95, ''),
(614002, 'BUBBLE MILK TEA', 85, ''),
(614003, 'COCOA CHOC', 95, ''),
(614004, 'CPPUCCINO', 115, ''),
(614005, 'CROISSANT', 65, ''),
(614006, 'CUISNE', 169, '-'),
(614007, 'BAKING', 80, '-'),
(614008, 'COOKISES', 69, '-'),
(614009, 'DONUT', 50, ''),
(614010, 'MAARONG', 109, ''),
(614011, 'ESPRESSO', 109, '-'),
(614012, 'CHEESE CAKE', 79, ''),
(614013, 'MATCHA MILK TEA', 99, ''),
(614014, 'ORIGINAL MILK TEA', 95, ''),
(614015, 'BROWN SUGAR', 99, ''),
(614016, 'AMERICANO', 129, ''),
(614017, 'BLUE SMOOTHIE', 79, '-'),
(614018, 'COCOA MATCHA ', 89, ''),
(614019, 'TIRAMISU', 115, ''),
(614020, 'CHOOCLATE CAKE', 115, ''),
(614021, 'RECIPES', 70, '-'),
(614022, 'BLACK COFFEE', 99, ''),
(614023, 'STRAWBERRY PIE', 65, ''),
(614024, 'CUP CAKE', 112, '');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SaleID` int(11) NOT NULL,
  `SaleDateTime` datetime NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `GrandTotal` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`SaleID`, `SaleDateTime`, `CustomerID`, `StaffID`, `GrandTotal`) VALUES
(15953, '2020-04-27 08:21:15', 123456, 91700, 70),
(17778, '2020-04-25 09:03:19', 337215, 91700, 140),
(26195, '2020-04-25 08:39:50', 834278, 73707, 319),
(28208, '2020-04-25 08:23:55', 337215, 91700, 210),
(33514, '2020-04-27 09:46:31', 0, 91700, 80),
(35753, '2020-04-27 08:21:59', 123456, 95698, 264),
(37185, '2020-04-24 11:05:55', 123456, 91700, 416),
(58181, '2020-04-27 08:20:17', 337215, 91700, 70),
(73704, '2020-04-25 08:48:21', 509122, 73707, 139),
(76849, '2020-04-25 08:49:23', 834278, 73707, 69),
(83299, '2020-04-25 08:25:28', 0, 91700, 264);

-- --------------------------------------------------------

--
-- Table structure for table `sale_details`
--

CREATE TABLE `sale_details` (
  `SaleDetailID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Price` float NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Amount` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sale_details`
--

INSERT INTO `sale_details` (`SaleDetailID`, `SaleID`, `ProductID`, `Price`, `Quantity`, `Amount`) VALUES
(10495, 37185, 614008, 69, 1, 69),
(15458, 33514, 614007, 80, 1, 80),
(15875, 26195, 614008, 69, 1, 69),
(19563, 26195, 614003, 95, 1, 95),
(22033, 58181, 614021, 70, 1, 70),
(23288, 37185, 614006, 169, 1, 169),
(23508, 26195, 614002, 85, 1, 85),
(27690, 26195, 614021, 70, 1, 70),
(32407, 83299, 614006, 169, 1, 169),
(35442, 28208, 614003, 95, 1, 95),
(36583, 35753, 614003, 95, 1, 95),
(41771, 28208, 614020, 115, 1, 115),
(47677, 83299, 614001, 95, 1, 95),
(50221, 73704, 614008, 69, 1, 69),
(53495, 35753, 614006, 169, 1, 169),
(63858, 76849, 614008, 69, 1, 69),
(67423, 17778, 614021, 140, 2, 280),
(67446, 15953, 614021, 70, 1, 70),
(87036, 73704, 614021, 70, 1, 70),
(95296, 37185, 614022, 99, 1, 99),
(97185, 37185, 614017, 79, 1, 79);

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `StaffID` int(11) NOT NULL,
  `StaffCode` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `StaffName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') COLLATE utf8_unicode_ci NOT NULL,
  `StaffPassword` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `StaffLevel` enum('Staff','Manager','Admin') COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES
(6, '100', 'Admin', 'M', '12345678', 'Admin'),
(65673, '496', 'a', 'M', 'a001', 'Manager'),
(67934, '004', 'd', 'F', 'd004', 'Staff'),
(73707, '106', 'chan', 'M', 'c003', 'Staff'),
(91700, '002', 'b', 'M', 'b002', 'Staff'),
(95698, '003', 'c', 'F', 'c003', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `sale_details`
--
ALTER TABLE `sale_details`
  ADD PRIMARY KEY (`SaleDetailID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `StaffCode` (`StaffCode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=834279;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61402019;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=987157;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99643;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95700;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
