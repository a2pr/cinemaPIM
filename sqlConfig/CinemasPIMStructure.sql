-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 22, 2020 at 02:22 AM
-- Server version: 5.6.37
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `example_cinema`
--

-- --------------------------------------------------------

--
-- Table structure for table `cadeiras`
--

CREATE TABLE `cadeiras` (
  `id` int(11) NOT NULL,
  `id_sala_id` int(11) NOT NULL,
  `linha` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `columna` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cards`
--

CREATE TABLE `cards` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `card_number` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `secure_number` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `id` int(11) NOT NULL,
  `id_endereco_id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `endereco_id` int(11) NOT NULL,
  `cpf` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefone` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `use_card` tinyint(1) DEFAULT NULL,
  `use_pimcoin` tinyint(1) DEFAULT NULL,
  `id_usuario_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `endereco`
--

CREATE TABLE `endereco` (
  `id` int(11) NOT NULL,
  `rua` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cidade` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `estado` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cpe` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `filme`
--

CREATE TABLE `filme` (
  `id` int(11) NOT NULL,
  `cinemas_id` int(11) DEFAULT NULL,
  `titulo` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `categorias` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `duration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ano_estreia` int(11) NOT NULL,
  `rating` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `ingressos`
--

CREATE TABLE `ingressos` (
  `id` int(11) NOT NULL,
  `cinema_id` int(11) NOT NULL,
  `id_cadeira_id` int(11) NOT NULL,
  `id_order_id` int(11) DEFAULT NULL,
  `horario` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `ingressos_filme`
--

CREATE TABLE `ingressos_filme` (
  `ingressos_id` int(11) NOT NULL,
  `filme_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `migration_versions`
--

CREATE TABLE `migration_versions` (
  `version` varchar(14) COLLATE utf8mb4_unicode_ci NOT NULL,
  `executed_at` datetime NOT NULL COMMENT '(DC2Type:datetime_immutable)'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `id` int(11) NOT NULL,
  `id_pagamento_id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pagamento`
--

CREATE TABLE `pagamento` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) DEFAULT NULL,
  `use_pimcoin` tinyint(1) DEFAULT NULL,
  `use_card` tinyint(1) DEFAULT NULL,
  `valor` double NOT NULL,
  `id_pim_coin_trans_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pim_coin`
--

CREATE TABLE `pim_coin` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL,
  `private_key_user` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pim_coin_trans`
--

CREATE TABLE `pim_coin_trans` (
  `id` int(11) NOT NULL,
  `hash_key_current` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hash_key_previous` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dtc` datetime NOT NULL,
  `pim_coin_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sala`
--

CREATE TABLE `sala` (
  `id` int(11) NOT NULL,
  `id_cinema_id` int(11) NOT NULL,
  `horarios` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `admin` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cadeiras`
--
ALTER TABLE `cadeiras`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_7081F4C61B81764F` (`id_sala_id`);

--
-- Indexes for table `cards`
--
ALTER TABLE `cards`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_4C258FD7BF9CE86` (`id_cliente_id`);

--
-- Indexes for table `cinemas`
--
ALTER TABLE `cinemas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_D7D63B9A3A5A5D4` (`id_endereco_id`);

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_50FE07D71BB76823` (`endereco_id`),
  ADD UNIQUE KEY `UNIQ_50FE07D77EB2C349` (`id_usuario_id`);

--
-- Indexes for table `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `filme`
--
ALTER TABLE `filme`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_3A387F00C5C76018` (`cinemas_id`);

--
-- Indexes for table `ingressos`
--
ALTER TABLE `ingressos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_8ED539D1C946E4F` (`id_cadeira_id`),
  ADD KEY `IDX_8ED539D1B4CB84B6` (`cinema_id`),
  ADD KEY `IDX_8ED539D1DD4481AD` (`id_order_id`);

--
-- Indexes for table `ingressos_filme`
--
ALTER TABLE `ingressos_filme`
  ADD PRIMARY KEY (`ingressos_id`,`filme_id`),
  ADD KEY `IDX_3F72F9C012373158` (`ingressos_id`),
  ADD KEY `IDX_3F72F9C0E6E418AD` (`filme_id`);

--
-- Indexes for table `migration_versions`
--
ALTER TABLE `migration_versions`
  ADD PRIMARY KEY (`version`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_F5299398C3AEF485` (`id_pagamento_id`),
  ADD KEY `IDX_F52993987BF9CE86` (`id_cliente_id`);

--
-- Indexes for table `pagamento`
--
ALTER TABLE `pagamento`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_3E1F4B16819793DF` (`id_pim_coin_trans_id`),
  ADD KEY `IDX_3E1F4B167BF9CE86` (`id_cliente_id`);

--
-- Indexes for table `pim_coin`
--
ALTER TABLE `pim_coin`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_AD584B107BF9CE86` (`id_cliente_id`);

--
-- Indexes for table `pim_coin_trans`
--
ALTER TABLE `pim_coin_trans`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_9F5709CC5A29E5` (`pim_coin_id`);

--
-- Indexes for table `sala`
--
ALTER TABLE `sala`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_E226041C34FE3891` (`id_cinema_id`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cadeiras`
--
ALTER TABLE `cadeiras`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7001;

--
-- AUTO_INCREMENT for table `cards`
--
ALTER TABLE `cards`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `endereco`
--
ALTER TABLE `endereco`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `filme`
--
ALTER TABLE `filme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `ingressos`
--
ALTER TABLE `ingressos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11892;

--
-- AUTO_INCREMENT for table `pagamento`
--
ALTER TABLE `pagamento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10894;

--
-- AUTO_INCREMENT for table `pim_coin`
--
ALTER TABLE `pim_coin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pim_coin_trans`
--
ALTER TABLE `pim_coin_trans`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `sala`
--
ALTER TABLE `sala`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cadeiras`
--
ALTER TABLE `cadeiras`
  ADD CONSTRAINT `FK_7081F4C61B81764F` FOREIGN KEY (`id_sala_id`) REFERENCES `sala` (`id`);

--
-- Constraints for table `cards`
--
ALTER TABLE `cards`
  ADD CONSTRAINT `FK_4C258FD7BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`);

--
-- Constraints for table `cinemas`
--
ALTER TABLE `cinemas`
  ADD CONSTRAINT `FK_D7D63B9A3A5A5D4` FOREIGN KEY (`id_endereco_id`) REFERENCES `endereco` (`id`);

--
-- Constraints for table `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `FK_50FE07D71BB76823` FOREIGN KEY (`endereco_id`) REFERENCES `endereco` (`id`),
  ADD CONSTRAINT `FK_50FE07D77EB2C349` FOREIGN KEY (`id_usuario_id`) REFERENCES `usuarios` (`id`);

--
-- Constraints for table `filme`
--
ALTER TABLE `filme`
  ADD CONSTRAINT `FK_3A387F00C5C76018` FOREIGN KEY (`cinemas_id`) REFERENCES `cinemas` (`id`);

--
-- Constraints for table `ingressos`
--
ALTER TABLE `ingressos`
  ADD CONSTRAINT `FK_8ED539D1B4CB84B6` FOREIGN KEY (`cinema_id`) REFERENCES `cinemas` (`id`),
  ADD CONSTRAINT `FK_8ED539D1C946E4F` FOREIGN KEY (`id_cadeira_id`) REFERENCES `cadeiras` (`id`),
  ADD CONSTRAINT `FK_8ED539D1DD4481AD` FOREIGN KEY (`id_order_id`) REFERENCES `order` (`id`);

--
-- Constraints for table `ingressos_filme`
--
ALTER TABLE `ingressos_filme`
  ADD CONSTRAINT `FK_3F72F9C012373158` FOREIGN KEY (`ingressos_id`) REFERENCES `ingressos` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_3F72F9C0E6E418AD` FOREIGN KEY (`filme_id`) REFERENCES `filme` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `FK_F52993987BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`),
  ADD CONSTRAINT `FK_F5299398C3AEF485` FOREIGN KEY (`id_pagamento_id`) REFERENCES `pagamento` (`id`);

--
-- Constraints for table `pagamento`
--
ALTER TABLE `pagamento`
  ADD CONSTRAINT `FK_3E1F4B167BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`),
  ADD CONSTRAINT `FK_3E1F4B16819793DF` FOREIGN KEY (`id_pim_coin_trans_id`) REFERENCES `pim_coin_trans` (`id`);

--
-- Constraints for table `pim_coin`
--
ALTER TABLE `pim_coin`
  ADD CONSTRAINT `FK_AD584B107BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`);

--
-- Constraints for table `pim_coin_trans`
--
ALTER TABLE `pim_coin_trans`
  ADD CONSTRAINT `FK_9F5709CC5A29E5` FOREIGN KEY (`pim_coin_id`) REFERENCES `pim_coin` (`id`);

--
-- Constraints for table `sala`
--
ALTER TABLE `sala`
  ADD CONSTRAINT `FK_E226041C34FE3891` FOREIGN KEY (`id_cinema_id`) REFERENCES `cinemas` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
