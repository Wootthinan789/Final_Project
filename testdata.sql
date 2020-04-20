-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 19, 2020 at 05:39 AM
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
(614002, 'Arista', 'F', 'VIP', '0941784456'),
(614008, 'Athena', 'F', 'Member', '0981256444'),
(614012, 'Amber', 'M', 'Member', '0648741257'),
(614056, 'Amelia', 'M', 'Other', '0814595634'),
(614098, 'Alice', 'F', 'VIP', '0657706835');

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
(614001, 'aaa', 145, '1.100% Brand New'),
(614002, 'bbb', 200, 'Material:  TPU '),
(614003, 'ccc', 520, 'Compatible Phone Model: For iPhone 6 6s 7 8 X 6Plus 6sPlus 7Plus 8Plus XR XSmax XS 11 11pro max'),
(614004, 'ddd', 100, 'Fashion design, easy to put on and easy to take off.'),
(614005, 'eee', 564, 'Perfectly fits the shape.'),
(614006, 'rr', 250, 'awr'),
(614007, 'awer', 612, 'awer'),
(614008, 'gdfrtyy', 652, 'ert'),
(614010, 'ury6r5', 452, 'tiy7');

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
(369545, '2020-04-03 05:30:19', 614012, 2, 725),
(411564, '2020-03-24 05:11:31', 614098, 4, 1529),
(547863, '2020-03-28 18:19:38', 614056, 1, 500),
(635741, '2020-04-30 15:21:39', 614002, 2, 725),
(654187, '2020-04-01 15:17:39', 614056, 2, 1540),
(657312, '2020-04-02 04:30:17', 614098, 3, 1000),
(785241, '2020-04-04 09:11:33', 614056, 4, 2820),
(786341, '2020-03-27 14:21:39', 614008, 4, 1848),
(800044, '2020-03-19 06:14:10', 614008, 1, 1145),
(987156, '2020-03-25 04:49:10', 614012, 5, 2600);

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
(1258, 786341, 614004, 100, 2, 200),
(1596, 785241, 614005, 564, 5, 2820),
(2587, 654187, 614004, 100, 1, 100),
(3512, 635741, 614001, 145, 5, 725),
(3657, 411564, 614005, 564, 1, 564),
(4189, 800044, 614001, 145, 1, 145),
(4190, 800044, 614002, 200, 5, 1000),
(4526, 657312, 614002, 200, 5, 1000),
(4899, 654187, 614003, 520, 2, 1040),
(5634, 987156, 614003, 520, 5, 2600),
(6357, 614056, 614056, 100, 5, 500),
(6537, 654187, 614002, 200, 2, 400),
(6743, 411564, 614004, 100, 1, 100),
(6841, 411564, 614002, 200, 1, 200),
(7456, 786341, 614003, 520, 1, 520),
(8934, 411564, 614001, 145, 1, 145),
(8935, 411564, 614003, 520, 1, 520),
(9345, 786341, 614005, 564, 2, 1128),
(9782, 635741, 614001, 145, 5, 725);

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
(5, '005', 'e', 'F', 'e005', 'Staff');

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
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=614099;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6145129;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=987157;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9783;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
