-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 22, 2020 at 04:52 AM
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
(614007, 1),
(614011, 1),
(614015, 1),
(614021, 1),
(614003, 1),
(614002, 1),
(614004, 1),
(614010, 1);

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
(614002, 'Arista', 'F', 'VIP', '0657706835'),
(614008, 'Athena', 'F', 'Member', '0981256444'),
(614012, 'Amber', 'M', 'Member', '0648741257'),
(614056, 'Amelia', 'M', 'Other', '0814595634'),
(614098, 'Alice', 'F', 'VIP', '0657706835');

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

--
-- Dumping data for table `login_save`
--

INSERT INTO `login_save` (`staffsID`) VALUES
(2);

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
(614006, 'CUISNE', 169, ''),
(614007, 'BAKING', 70, ''),
(614008, 'COOKISE', 69, ''),
(614009, 'DONUT', 50, ''),
(614010, 'MAARONG', 109, ''),
(614011, 'ESPRESSO', 109, ''),
(614012, 'CHEESE CAKE', 79, ''),
(614013, 'MATCHA BUBBLE MILK TEA', 99, ''),
(614014, 'ORIGINAL MILK TEA', 95, ''),
(614015, 'BROWN SUGAR BUBBLE MILK TEA', 99, ''),
(614016, 'AMERICANO', 129, ''),
(614017, 'BLUEBRRY SMOOTHIE', 79, ''),
(614018, 'COCOA MATCHA TEA', 89, ''),
(614019, 'TIRAMISU', 115, ''),
(614020, 'CHOOCLATE CAKE', 115, ''),
(614021, 'RECIPES', 70, ''),
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
(71864, '2020-04-21 08:06:42', 123456, 2, 752),
(87085, '2020-04-21 08:06:42', 123456, 2, 752);

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
(12361, 71864, 614007, 70, 1, 70),
(17410, 87085, 614021, 70, 1, 70),
(30721, 71864, 614003, 95, 1, 95),
(35206, 87085, 614002, 85, 1, 85),
(38281, 87085, 614011, 109, 1, 109),
(41559, 87085, 614004, 115, 1, 115),
(56206, 87085, 614015, 99, 1, 99),
(56862, 87085, 614010, 109, 1, 109),
(57773, 71864, 614002, 85, 1, 85),
(60212, 87085, 614003, 95, 1, 95),
(69330, 71864, 614015, 99, 1, 99),
(79630, 71864, 614021, 70, 1, 70),
(85629, 87085, 614007, 70, 1, 70),
(86152, 71864, 614010, 109, 1, 109),
(89522, 71864, 614011, 109, 1, 109),
(97338, 71864, 614004, 115, 1, 115);

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
(1, '001', 'a', 'M', 'a001', 'Manager'),
(2, '002', 'b', 'M', 'b002', 'Staff'),
(3, '003', 'c', 'F', 'c003', 'Staff'),
(4, '004', 'd', 'F', 'd004', 'Staff'),
(5, '005', 'e', 'F', 'e005', 'Staff'),
(6, '100', 'Admin', 'M', '12345678', 'Admin');

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
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=614100;

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
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99481;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
