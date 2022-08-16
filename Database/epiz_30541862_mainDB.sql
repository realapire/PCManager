-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: sql106.epizy.com
-- Generation Time: May 30, 2022 at 08:01 PM
-- Server version: 10.3.27-MariaDB
-- PHP Version: 7.2.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `epiz_30541862_mainDB`
--

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `setting_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `pcspecs_themeIndex` int(11) NOT NULL,
  `pcspecs_filterIndex` int(11) NOT NULL,
  `pcmanager_themeIndex` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`setting_id`, `username`, `pcspecs_themeIndex`, `pcspecs_filterIndex`, `pcmanager_themeIndex`) VALUES
(1, 'admin', 2, 1, 1),
(2, 'awais', 0, 0, 0),
(3, 'aa', 0, 0, 0),
(4, 'aaaa', 0, 0, 0),
(5, 'andre', 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `timestamps`
--

CREATE TABLE `timestamps` (
  `timestamp_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `cleaner_timestamp` varchar(50) NOT NULL DEFAULT 'Not used yet',
  `renewip_timestamp` varchar(50) NOT NULL DEFAULT 'Not used yet',
  `releaseip_timestamp` varchar(50) NOT NULL DEFAULT 'Not used yet',
  `flushdns_timestamp` varchar(50) NOT NULL DEFAULT 'Not used yet'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `timestamps`
--

INSERT INTO `timestamps` (`timestamp_id`, `username`, `cleaner_timestamp`, `renewip_timestamp`, `releaseip_timestamp`, `flushdns_timestamp`) VALUES
(1, 'admin', 'Monday, 30 May 2022 at 21:56', 'Not used yet', 'Not used yet', 'Thursday, 28 April 2022 at 15:42'),
(2, 'awais', 'Not used yet', 'Not used yet', 'Not used yet', 'Not used yet'),
(3, 'aa', 'Not used yet', 'Not used yet', 'Not used yet', 'Not used yet'),
(4, 'aaaa', 'Not used yet', 'Not used yet', 'Not used yet', 'Not used yet'),
(5, 'andre', 'Not used yet', 'Not used yet', 'Not used yet', 'Not used yet');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `username`, `password`) VALUES
(1, 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997'),
(2, 'awais', 'e62beeaeeb63160e1b4000b468bae8786072ff16'),
(3, 'aa', 'a0f1490a20d0211c997b44bc357e1972deab8ae3'),
(4, 'aaaa', 'f7a9e24777ec23212c54d7a350bc5bea5477fdbb'),
(5, 'andre', '02e0a999c50b1f88df7a8f5a04e1b76b35ea6a88');

-- --------------------------------------------------------

--
-- Table structure for table `win32classes`
--

CREATE TABLE `win32classes` (
  `class_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `class` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `win32classes`
--

INSERT INTO `win32classes` (`class_id`, `username`, `class`) VALUES
(1, 'awais', 'Win32_Printer'),
(3, 'admin', 'Win32_Printer'),
(4, 'admin', 'Win32_VideoController'),
(5, 'admin', 'Win32_VideoController'),
(6, 'admin', 'Win32_Printer'),
(7, 'admin', 'Win32_Printer'),
(8, 'admin', 'Win32_Printer');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`setting_id`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `timestamps`
--
ALTER TABLE `timestamps`
  ADD PRIMARY KEY (`timestamp_id`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `win32classes`
--
ALTER TABLE `win32classes`
  ADD PRIMARY KEY (`class_id`),
  ADD KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `settings`
--
ALTER TABLE `settings`
  MODIFY `setting_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `timestamps`
--
ALTER TABLE `timestamps`
  MODIFY `timestamp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `win32classes`
--
ALTER TABLE `win32classes`
  MODIFY `class_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `settings`
--
ALTER TABLE `settings`
  ADD CONSTRAINT `settings_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `timestamps`
--
ALTER TABLE `timestamps`
  ADD CONSTRAINT `timestamps_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `win32classes`
--
ALTER TABLE `win32classes`
  ADD CONSTRAINT `win32classes_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
