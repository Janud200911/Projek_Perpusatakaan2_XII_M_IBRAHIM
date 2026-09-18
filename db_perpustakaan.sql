-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 05, 2026 at 07:42 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_anggota`
--

CREATE TABLE `t_anggota` (
  `id_anggota` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jk` enum('L','P') NOT NULL,
  `alamat` text NOT NULL,
  `no_hp` varchar(20) NOT NULL,
  `tgl_daftar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_anggota`
--

INSERT INTO `t_anggota` (`id_anggota`, `nama`, `jk`, `alamat`, `no_hp`, `tgl_daftar`) VALUES
(1, 'Ahmad_Fauzi', 'L', 'Bandung', '0812234676', '2026-07-01'),
(2, 'Saripah', 'P', 'Gotham', '08123456', '2026-07-02'),
(3, 'Fajar_Maulana', 'L', 'Cimahi', '08123456', '2026-07-03');

-- --------------------------------------------------------

--
-- Table structure for table `t_buku`
--

CREATE TABLE `t_buku` (
  `id_buku` int(11) NOT NULL,
  `judul` varchar(150) NOT NULL,
  `pengarang` varchar(100) NOT NULL,
  `penerbit` varchar(100) NOT NULL,
  `tahun` year(4) NOT NULL,
  `stok` int(11) NOT NULL,
  `id_kategori` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_buku`
--

INSERT INTO `t_buku` (`id_buku`, `judul`, `pengarang`, `penerbit`, `tahun`, `stok`, `id_kategori`) VALUES
(1, 'bba', 'dd', 'baim', '2000', 12, 1),
(2, 'adad', 'dede', 'wewe', '2009', 12, 2),
(6, 'Dunia Imaji', 'Js.Khaireen', 'TBJaya', '2027', 234, 3),
(9, 'Seporsi Mie Ayam', 'Jhoim', 'Berkah', '2026', 112, 1),
(10, 'anjay', 'sas', 'ded', '2021', 12, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_detail_peminjaman`
--

CREATE TABLE `t_detail_peminjaman` (
  `id_detail` int(11) NOT NULL,
  `id_pinjam` int(11) NOT NULL,
  `id_buku` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_detail_peminjaman`
--

INSERT INTO `t_detail_peminjaman` (`id_detail`, `id_pinjam`, `id_buku`, `jumlah`) VALUES
(1, 1, 1, 1),
(2, 1, 5, 1),
(3, 2, 4, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_kategori`
--

CREATE TABLE `t_kategori` (
  `id_kategori` int(11) NOT NULL,
  `kategori` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_kategori`
--

INSERT INTO `t_kategori` (`id_kategori`, `kategori`) VALUES
(1, 'Novel'),
(2, 'Komik'),
(3, 'Pembelajaran'),
(4, 'Teknologi'),
(5, 'Sejarah');

-- --------------------------------------------------------

--
-- Table structure for table `t_peminjaman`
--

CREATE TABLE `t_peminjaman` (
  `id_pinjam` int(11) NOT NULL,
  `tgl_pinjam` date NOT NULL,
  `tgl_jatuh_tempo` date NOT NULL,
  `nama_peminjam` varchar(100) NOT NULL,
  `id_buku` int(11) NOT NULL,
  `id_anggota` int(11) NOT NULL,
  `id_petugas` int(11) NOT NULL,
  `status` enum('di pinjam','selesai') NOT NULL,
  `denda` int(11) DEFAULT 0,
  `keterangan` varchar(200) DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_peminjaman`
--

INSERT INTO `t_peminjaman` (`id_pinjam`, `tgl_pinjam`, `tgl_jatuh_tempo`, `nama_peminjam`, `id_buku`, `id_anggota`, `id_petugas`, `status`, `denda`, `keterangan`) VALUES
(1, '2026-07-20', '2026-07-27', '', 0, 1, 2, 'selesai', 0, ''),
(2, '2026-07-25', '2026-08-01', '', 0, 3, 2, 'di pinjam', 0, ''),
(3, '2026-09-05', '2026-09-06', 'im', 6, 0, 9, 'selesai', 0, 'Tepat waktu'),
(4, '2026-09-05', '2026-09-06', 'ew', 6, 0, 9, 'selesai', 2000, 'Telat 2 hari'),
(5, '2026-09-05', '2026-09-06', 'fed', 2, 0, 9, 'selesai', 20000, 'Kerusakan buku');

-- --------------------------------------------------------

--
-- Table structure for table `t_pengembalian`
--

CREATE TABLE `t_pengembalian` (
  `id_kembali` int(11) NOT NULL,
  `id_pinjam` int(11) NOT NULL,
  `tgl_kembali` int(11) NOT NULL,
  `terlambat` int(11) NOT NULL,
  `denda` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_pengembalian`
--

INSERT INTO `t_pengembalian` (`id_kembali`, `id_pinjam`, `tgl_kembali`, `terlambat`, `denda`) VALUES
(1, 1, 2026, 1, 2000.00);

-- --------------------------------------------------------

--
-- Table structure for table `t_petugas`
--

CREATE TABLE `t_petugas` (
  `id_petugas` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` enum('admin','petugas') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_petugas`
--

INSERT INTO `t_petugas` (`id_petugas`, `nama`, `username`, `password`, `level`) VALUES
(9, 'Admin', 'admin', 'admin123', 'admin'),
(10, 'Toto', 'petugas', 'petugas123', 'petugas'),
(11, 'imah', 'imah123', 'Petugas', ''),
(12, 'imah', 'imah', 'imah123', 'petugas'),
(13, 'junedd', 'juned', 'juned123', 'admin'),
(14, 'Bohim', 'Bohim', '1234', 'petugas');

-- --------------------------------------------------------

--
-- Table structure for table `t_role`
--

CREATE TABLE `t_role` (
  `id_role` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Role` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_role`
--

INSERT INTO `t_role` (`id_role`, `Nama`, `Role`) VALUES
(1, 'imah', 'admin'),
(3, 'dino', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_anggota`
--
ALTER TABLE `t_anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indexes for table `t_buku`
--
ALTER TABLE `t_buku`
  ADD PRIMARY KEY (`id_buku`),
  ADD KEY `id_kategori` (`id_kategori`);

--
-- Indexes for table `t_detail_peminjaman`
--
ALTER TABLE `t_detail_peminjaman`
  ADD PRIMARY KEY (`id_detail`);

--
-- Indexes for table `t_kategori`
--
ALTER TABLE `t_kategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indexes for table `t_peminjaman`
--
ALTER TABLE `t_peminjaman`
  ADD PRIMARY KEY (`id_pinjam`);

--
-- Indexes for table `t_pengembalian`
--
ALTER TABLE `t_pengembalian`
  ADD PRIMARY KEY (`id_kembali`);

--
-- Indexes for table `t_petugas`
--
ALTER TABLE `t_petugas`
  ADD PRIMARY KEY (`id_petugas`);

--
-- Indexes for table `t_role`
--
ALTER TABLE `t_role`
  ADD PRIMARY KEY (`id_role`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_anggota`
--
ALTER TABLE `t_anggota`
  MODIFY `id_anggota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `t_buku`
--
ALTER TABLE `t_buku`
  MODIFY `id_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `t_detail_peminjaman`
--
ALTER TABLE `t_detail_peminjaman`
  MODIFY `id_detail` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `t_kategori`
--
ALTER TABLE `t_kategori`
  MODIFY `id_kategori` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `t_peminjaman`
--
ALTER TABLE `t_peminjaman`
  MODIFY `id_pinjam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `t_pengembalian`
--
ALTER TABLE `t_pengembalian`
  MODIFY `id_kembali` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `t_petugas`
--
ALTER TABLE `t_petugas`
  MODIFY `id_petugas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `t_role`
--
ALTER TABLE `t_role`
  MODIFY `id_role` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_buku`
--
ALTER TABLE `t_buku`
  ADD CONSTRAINT `fk_buku_kategori` FOREIGN KEY (`id_kategori`) REFERENCES `t_kategori` (`id_kategori`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
