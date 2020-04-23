-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2020 at 04:12 PM
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
(614015, 1);

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
(614001, 'aaa', 145, '1.100% Brand New'),
(614002, 'bbb', 200, 'Material:  TPU '),
(614003, 'ccc', 520, 'Compatible Phone Model: For iPhone 6 6s 7 8 X 6Plus 6sPlus 7Plus 8Plus XR XSmax XS 11 11pro max'),
(614004, 'ddd', 100, 'Fashion design, easy to put on and easy to take off.'),
(614005, 'eee', 564, 'Perfectly fits the shape.'),
(614006, 'rr', 250, 'awr'),
(614007, 'awer', 612, 'awer'),
(614008, 'gdfrtyy', 652, 'ert'),
(614009, 'gfg', 100, 'ert'),
(614010, 'ury6r5', 452, 'tiy7'),
(614011, 'tyhj', 230, '6yr56'),
(614012, 'dffre', 120, 'tfhr'),
(614013, 'ergde', 123, 'rt6hy'),
(614014, 'erge', 110, 'fghnjfg'),
(614015, 'dfgvds', 230, 'dgrf'),
(614016, 'fsf', 450, 'e5thy'),
(614017, 'rhyrt', 230, 'sdfg'),
(614018, 'wsf', 780, 'sadafwesf'),
(614019, 'dsvsd', 150, 'drfgdr'),
(614020, 'dfbvd', 321, 'dfgd'),
(614021, 'dfer', 89, 'ghrt'),
(614022, 'ergt', 189, 'drgfer'),
(614023, 'sdfg', 159, 'sedf'),
(614024, 'sef', 658, 'fhttyh');

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
(15808, '2020-04-21 08:06:42', 614098, 2, 6681),
(33405, '2020-04-21 08:06:42', 614098, 2, 26724),
(35537, '2020-04-21 08:06:42', 123456, 2, 6681),
(42093, '2020-04-21 07:56:00', 614098, 2, 2080),
(47420, '0000-00-00 00:00:00', 614098, 2, 2080),
(50888, '2020-04-21 07:56:00', 614098, 2, 2080),
(51475, '2020-04-21 07:56:00', 614098, 2, 2080),
(52007, '0000-00-00 00:00:00', 614098, 2, 3096),
(61849, '0000-00-00 00:00:00', 614098, 2, 2080),
(72159, '0000-00-00 00:00:00', 614098, 2, 3096),
(81862, '2020-04-21 08:03:22', 614098, 2, 2080);

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
(10996, 35537, 614003, 520, 1, 520),
(11607, 51475, 614004, 500, 5, 2500),
(11641, 81862, 614005, 1128, 2, 2256),
(11934, 33405, 614008, 452, 5, 452),
(12919, 50888, 614005, 1128, 2, 2256),
(14043, 61849, 614005, 1128, 2, 2256),
(14396, 88887, 614005, 564, 1, 564),
(15194, 42093, 614010, 452, 1, 452),
(15491, 52007, 614003, 520, 1, 520),
(16732, 99885, 614010, 452, 1, 452),
(19745, 88887, 614005, 1128, 2, 2256),
(23516, 88887, 614007, 612, 1, 612),
(23657, 61849, 614004, 500, 5, 2500),
(24546, 35537, 614007, 612, 1, 612),
(25447, 15808, 614008, 3260, 5, 16300),
(26037, 99885, 614004, 500, 5, 2500),
(26217, 33405, 614005, 1128, 2, 2256),
(27774, 88887, 614004, 500, 5, 2500),
(30938, 88887, 614010, 452, 1, 452),
(31603, 15808, 614005, 1128, 2, 2256),
(32589, 33405, 614008, 3260, 5, 16300),
(34150, 42093, 614005, 1128, 2, 2256),
(35581, 33405, 614005, 564, 1, 564),
(36053, 47420, 614010, 452, 1, 452),
(36577, 52007, 614006, 250, 1, 250),
(37626, 15808, 614007, 612, 1, 612),
(37676, 52007, 614003, 520, 1, 520),
(40660, 15808, 614010, 452, 1, 452),
(41205, 47420, 614005, 1128, 2, 2256),
(44017, 15808, 614001, 145, 1, 145),
(45104, 72159, 614010, 904, 2, 1808),
(45699, 42093, 614004, 500, 5, 2500),
(45945, 81862, 614004, 500, 5, 2500),
(46849, 35537, 614005, 564, 1, 564),
(47798, 33405, 614003, 3260, 1, 16300),
(49578, 72159, 614006, 250, 1, 250),
(49870, 47420, 614004, 500, 5, 2500),
(50222, 72159, 614008, 652, 1, 652),
(53587, 51475, 614005, 1128, 2, 2256),
(55886, 35537, 614008, 3260, 5, 16300),
(56133, 33405, 614010, 452, 1, 452),
(60120, 35537, 614001, 145, 1, 145),
(64699, 50888, 614010, 452, 1, 452),
(65166, 33405, 614003, 520, 1, 520),
(67060, 33405, 614005, 452, 1, 452),
(69124, 51475, 614010, 452, 1, 452),
(73590, 52007, 614008, 652, 1, 652),
(75740, 72159, 614003, 520, 1, 520),
(77409, 35537, 614010, 452, 1, 452),
(78193, 88887, 614003, 520, 1, 520),
(79345, 88887, 614008, 3260, 5, 16300),
(79452, 33405, 614001, 564, 1, 564),
(79764, 33405, 614007, 612, 1, 612),
(80129, 81862, 614010, 452, 1, 452),
(80362, 35537, 614005, 1128, 2, 2256),
(81517, 50888, 614004, 500, 5, 2500),
(85324, 52007, 614010, 904, 2, 1808),
(87017, 33405, 614007, 3260, 1, 16300),
(88249, 33405, 614001, 145, 1, 145),
(88513, 52007, 614006, 250, 1, 250),
(89125, 33405, 614010, 1128, 1, 2256),
(91424, 15808, 614005, 564, 1, 564),
(91817, 15808, 614003, 520, 1, 520),
(91859, 99885, 614005, 1128, 2, 2256),
(91951, 61849, 614010, 452, 1, 452),
(95530, 33405, 614005, 1128, 2, 2256),
(98857, 72159, 614006, 250, 1, 250),
(99480, 72159, 614003, 520, 1, 520);

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
