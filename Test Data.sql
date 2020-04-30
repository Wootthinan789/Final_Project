-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 23, 2020 at 06:37 AM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
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
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
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
(614008, 'COOKISE', 69, ''),
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
(614021, 'RECIPES', 70, ''),
(614022, 'BLACK COFFEE', 99, ''),
(614023, 'STRAWBERRY PIE', 65, ''),
(614024, 'CUP CAKE', 112, '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61402019;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
