-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 07-Dez-2018 às 13:28
-- Versão do servidor: 10.1.37-MariaDB
-- versão do PHP: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdlp`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_cliente`
--

CREATE TABLE `tab_cliente` (
  `id_cliente` int(11) NOT NULL,
  `data_cadastro` date NOT NULL,
  `nome` varchar(40) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `nascimento` date NOT NULL,
  `generofavorito` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tab_cliente`
--

INSERT INTO `tab_cliente` (`id_cliente`, `data_cadastro`, `nome`, `cpf`, `nascimento`, `generofavorito`) VALUES
(21, '2018-12-05', 'Pedro de Alcântara', '55533114799', '1831-04-07', 'Documentario'),
(15, '2018-12-05', 'Leopoldina de Bragança', '88112377861', '1847-07-13', 'Drama'),
(14, '2018-12-05', 'Afonso Pedro', '48239971582', '1845-02-23', 'Ação'),
(16, '2018-12-05', 'Isabel Cristina', '55662223314', '1846-07-29', 'Fantasia'),
(17, '2018-12-05', 'Carlos Cesar', '77812234793', '1994-01-21', 'Terror'),
(18, '2018-12-05', 'Paulo Silva', '69721583301', '1995-07-03', 'Terror'),
(19, '2018-12-05', 'Ana Carla', '97812534900', '1993-12-04', 'Drama'),
(20, '2018-12-05', 'Maria Lurdes', '45543877333', '1985-03-13', 'Ação'),
(22, '2018-12-05', 'Antonio Alves', '35680170580', '2002-06-27', 'Fantasia'),
(23, '2018-12-05', 'Joca Silva', '35877412504', '1982-08-20', 'Aventura');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_cliente_emprestimo`
--

CREATE TABLE `tab_cliente_emprestimo` (
  `id_dvd` int(10) NOT NULL,
  `data_retirada` date NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `data_venda` date NOT NULL,
  `id_venda` int(12) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tab_cliente_emprestimo`
--

INSERT INTO `tab_cliente_emprestimo` (`id_dvd`, `data_retirada`, `id_cliente`, `quantidade`, `data_venda`, `id_venda`) VALUES
(25, '2018-12-05', 8, 2, '2018-12-05', 1),
(28, '2018-12-05', 16, 2, '2018-12-05', 2),
(33, '2018-12-29', 14, 1, '2018-12-05', 3),
(29, '2018-12-26', 22, 1, '2018-12-05', 4),
(32, '2019-02-01', 19, 5, '2018-12-05', 5),
(30, '2019-01-02', 16, 1, '2018-12-05', 6),
(35, '2018-12-15', 17, 1, '2018-12-05', 7),
(37, '2018-12-18', 21, 2, '2018-12-05', 8),
(38, '2018-12-20', 15, 1, '2018-12-05', 9),
(34, '2018-12-13', 23, 1, '2018-12-05', 10),
(28, '2018-12-07', 14, 0, '2018-12-07', 11),
(28, '2018-12-07', 14, 0, '2018-12-07', 12),
(28, '2018-12-07', 14, 0, '2018-12-07', 13),
(28, '2018-12-07', 14, 0, '2018-12-07', 14),
(28, '2018-12-07', 14, 0, '2018-12-07', 15),
(28, '2018-12-07', 14, 0, '2018-12-07', 16),
(28, '2018-12-07', 14, 0, '2018-12-07', 17),
(28, '2018-12-07', 14, 0, '2018-12-07', 18),
(28, '2018-12-07', 14, 0, '2018-12-07', 19),
(28, '2018-12-07', 14, 0, '2018-12-07', 20),
(28, '2018-12-07', 14, 0, '2018-12-07', 21),
(28, '2018-12-07', 14, 0, '2018-12-07', 22),
(28, '2018-12-07', 14, 0, '2018-12-07', 23),
(28, '2018-12-07', 14, 0, '2018-12-07', 24),
(28, '2018-12-07', 14, 0, '2018-12-07', 25),
(28, '2018-12-07', 14, 0, '2018-12-07', 26);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_dvd`
--

CREATE TABLE `tab_dvd` (
  `id_dvd` int(11) NOT NULL,
  `titulo` varchar(70) NOT NULL,
  `data` date NOT NULL,
  `genero` varchar(20) NOT NULL,
  `diretor` varchar(30) NOT NULL,
  `duracao` int(11) NOT NULL,
  `idade` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tab_dvd`
--

INSERT INTO `tab_dvd` (`id_dvd`, `titulo`, `data`, `genero`, `diretor`, `duracao`, `idade`) VALUES
(28, 'Senhor dos Aneis: A Sociedade do Anel', '2001-12-05', 'Fantasia', 'Peter Jackson', 178, '12'),
(29, 'Senhor dos Aneis: O Retorno do Rei', '2003-07-02', 'Fantasia', 'Peter Jackson', 201, '12'),
(30, 'Avatar', '2009-06-03', 'Ação', 'James Cameron', 162, '16'),
(31, 'Hancock', '2008-08-06', 'Ação', 'Peter Berg', 92, '12'),
(32, 'Kill Bill', '2003-03-08', 'Ação', 'Peter Quentin Tarantino', 111, '18'),
(33, 'Senhor das Armas', '2003-03-08', 'Drama', 'Andrew Niccol', 123, '18'),
(34, 'A Culpa é das Estrelas', '2014-06-05', 'Romance', 'Josh Boone', 125, '12'),
(35, 'Jumanji', '2018-01-04', 'Fantasia', 'Jake Kasdan', 119, '12'),
(36, 'Velozes e Furiosos', '2001-09-28', 'Ação', 'Rob Cohen', 107, '16'),
(37, 'Jurassic Park', '1993-08-16', 'Aventura', 'Steven Spielberg', 122, '10'),
(38, 'As Crônicas de Nárnia: O Leão,a Feticeira e o Guarda-Roupa', '2005-03-24', 'Aventura', 'Andrew Adamson', 143, '10');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_teste`
--

CREATE TABLE `tab_teste` (
  `texto1` text NOT NULL,
  `texto2` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tab_cliente`
--
ALTER TABLE `tab_cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indexes for table `tab_cliente_emprestimo`
--
ALTER TABLE `tab_cliente_emprestimo`
  ADD PRIMARY KEY (`id_venda`);

--
-- Indexes for table `tab_dvd`
--
ALTER TABLE `tab_dvd`
  ADD PRIMARY KEY (`id_dvd`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tab_cliente`
--
ALTER TABLE `tab_cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `tab_cliente_emprestimo`
--
ALTER TABLE `tab_cliente_emprestimo`
  MODIFY `id_venda` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tab_dvd`
--
ALTER TABLE `tab_dvd`
  MODIFY `id_dvd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
