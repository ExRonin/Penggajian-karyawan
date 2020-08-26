-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 10 Des 2019 pada 09.35
-- Versi server: 10.1.37-MariaDB
-- Versi PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `prafit`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `id_kode_jabatan` int(10) NOT NULL,
  `Nip` int(12) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Kode_jabatan` varchar(10) NOT NULL,
  `Jabatan` varchar(20) NOT NULL,
  `Gaji_pokok` int(50) NOT NULL,
  `Tunjangan_lembur` int(50) NOT NULL,
  `Status` varchar(25) NOT NULL,
  `Tunjangan_istri` int(50) NOT NULL,
  `Jml_anak` int(50) NOT NULL,
  `Tunjangan_anak` int(50) NOT NULL,
  `Gaji_kotor` int(50) NOT NULL,
  `Pajak` varchar(50) NOT NULL,
  `Jam_lembur` varchar(50) NOT NULL,
  `Gaji_lembur` int(50) NOT NULL,
  `Gaji_bersih` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `karyawan`
--

INSERT INTO `karyawan` (`id_kode_jabatan`, `Nip`, `Nama`, `Kode_jabatan`, `Jabatan`, `Gaji_pokok`, `Tunjangan_lembur`, `Status`, `Tunjangan_istri`, `Jml_anak`, `Tunjangan_anak`, `Gaji_kotor`, `Pajak`, `Jam_lembur`, `Gaji_lembur`, `Gaji_bersih`) VALUES
(5, 4, 'suryokana2', 'KJ-03', 'Kabag', 4000000, 40000, 'KJ-03', 0, 2, 0, 4000000, '400000', '3', 40000, 8715000),
(6, 5, 'saya', 'KJ-02', 'Manager', 5000000, 50000, 'KJ-02', 1000000, 2, 750000, 6750000, '675000', '3', 50000, 6225000);

--
-- Trigger `karyawan`
--
DELIMITER $$
CREATE TRIGGER `logGaji` AFTER INSERT ON `karyawan` FOR EACH ROW BEGIN
INSERT INTO logging(nama,total_nominal_gaji)VALUES(NEW.nip,NEW.gaji_bersih);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `logging`
--

CREATE TABLE `logging` (
  `tgl_log` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `nama` varchar(50) NOT NULL,
  `total_nominal_gaji` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `logging`
--

INSERT INTO `logging` (`tgl_log`, `nama`, `total_nominal_gaji`) VALUES
('2019-12-10 07:11:08', '1119', '9000000'),
('2019-12-10 07:30:08', '190', '0'),
('2019-12-10 07:36:43', '180', '6300000'),
('2019-12-10 08:02:33', '1', '8715000'),
('2019-12-10 08:03:13', '4', '8715000'),
('2019-12-10 08:16:03', '5', '6225000');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`username`);

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id_kode_jabatan`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `id_kode_jabatan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
