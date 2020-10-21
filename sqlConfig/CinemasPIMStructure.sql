-- phpMyAdmin SQL Dump
-- version 4.4.15.9
-- https://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 31-05-2020 a las 17:08:01
-- Versión del servidor: 5.6.37
-- Versión de PHP: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `copyCinemasPIM`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cadeiras`
--

CREATE TABLE IF NOT EXISTS `cadeiras` (
  `id` int(11) NOT NULL,
  `id_sala_id` int(11) NOT NULL,
  `linha` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `columna` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cards`
--

CREATE TABLE IF NOT EXISTS `cards` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `card_number` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `secure_number` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cinemas`
--

CREATE TABLE IF NOT EXISTS `cinemas` (
  `id` int(11) NOT NULL,
  `id_endereco_id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
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
-- Estructura de tabla para la tabla `endereco`
--

CREATE TABLE IF NOT EXISTS `endereco` (
  `id` int(11) NOT NULL,
  `rua` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cidade` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `estado` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cpe` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `filme`
--

CREATE TABLE IF NOT EXISTS `filme` (
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
-- Estructura de tabla para la tabla `ingressos`
--

CREATE TABLE IF NOT EXISTS `ingressos` (
  `id` int(11) NOT NULL,
  `cinema_id` int(11) NOT NULL,
  `id_cadeira_id` int(11) NOT NULL,
  `id_order_id` int(11) DEFAULT NULL,
  `horario` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingressos_filme`
--

CREATE TABLE IF NOT EXISTS `ingressos_filme` (
  `ingressos_id` int(11) NOT NULL,
  `filme_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `migration_versions`
--

CREATE TABLE IF NOT EXISTS `migration_versions` (
  `version` varchar(14) COLLATE utf8mb4_unicode_ci NOT NULL,
  `executed_at` datetime NOT NULL COMMENT '(DC2Type:datetime_immutable)'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `id` int(11) NOT NULL,
  `id_pagamento_id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagamento`
--

CREATE TABLE IF NOT EXISTS `pagamento` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) DEFAULT NULL,
  `use_pimcoin` tinyint(1) DEFAULT NULL,
  `use_card` tinyint(1) DEFAULT NULL,
  `valor` double NOT NULL, 
  'id_pim_coin_trans_id' int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pim_coin`
--

CREATE TABLE IF NOT EXISTS `pim_coin` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL,
  `private_key_user` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `id` int(11) NOT NULL,
  `id_cinema_id` int(11) NOT NULL,
  `horarios` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `admin` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


CREATE TABLE IF NOT EXISTS  `pim_coin_trans`(
  `id` int(11) NOT NULL,
  `hash_key_current` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hash_key_previous` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dtc` DATETIME NOT NULL,
  `pim_coin_id` int(11) NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cadeiras`
--
ALTER TABLE `cadeiras`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_7081F4C61B81764F` (`id_sala_id`);

--
-- Indices de la tabla `cards`
--
ALTER TABLE `cards`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_4C258FD7BF9CE86` (`id_cliente_id`);

--
-- Indices de la tabla `cinemas`
--
ALTER TABLE `cinemas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_D7D63B9A3A5A5D4` (`id_endereco_id`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_50FE07D71BB76823` (`endereco_id`),
  ADD UNIQUE KEY `UNIQ_50FE07D77EB2C349` (`id_usuario_id`);

--
-- Indices de la tabla `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `filme`
--
ALTER TABLE `filme`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_3A387F00C5C76018` (`cinemas_id`);

--
-- Indices de la tabla `ingressos`
--
ALTER TABLE `ingressos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_8ED539D1C946E4F` (`id_cadeira_id`),
  ADD KEY `IDX_8ED539D1B4CB84B6` (`cinema_id`),
  ADD KEY `IDX_8ED539D1DD4481AD` (`id_order_id`);

--
-- Indices de la tabla `ingressos_filme`
--
ALTER TABLE `ingressos_filme`
  ADD PRIMARY KEY (`ingressos_id`,`filme_id`),
  ADD KEY `IDX_3F72F9C012373158` (`ingressos_id`),
  ADD KEY `IDX_3F72F9C0E6E418AD` (`filme_id`);

--
-- Indices de la tabla `migration_versions`
--
ALTER TABLE `migration_versions`
  ADD PRIMARY KEY (`version`);

--
-- Indices de la tabla `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_F5299398C3AEF485` (`id_pagamento_id`),
  ADD KEY `IDX_F52993987BF9CE86` (`id_cliente_id`);

--
-- Indices de la tabla `pagamento`
--
ALTER TABLE `pagamento`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_3E1F4B167BF9CE86` (`id_cliente_id`);

--
-- Indices de la tabla `pim_coin`
--
ALTER TABLE `pim_coin`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQ_AD584B107BF9CE86` (`id_cliente_id`);

--
-- Indices de la tabla `sala`
--
ALTER TABLE `sala`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IDX_E226041C34FE3891` (`id_cinema_id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cadeiras`
--
ALTER TABLE `cadeiras`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cards`
--
ALTER TABLE `cards`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `endereco`
--
ALTER TABLE `endereco`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `filme`
--
ALTER TABLE `filme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `ingressos`
--
ALTER TABLE `ingressos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `order`
--
ALTER TABLE `order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `pagamento`
--
ALTER TABLE `pagamento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `pim_coin`
--
ALTER TABLE `pim_coin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `sala`
--
ALTER TABLE `sala`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cadeiras`
--
ALTER TABLE `cadeiras`
  ADD CONSTRAINT `FK_7081F4C61B81764F` FOREIGN KEY (`id_sala_id`) REFERENCES `sala` (`id`);

--
-- Filtros para la tabla `cards`
--
ALTER TABLE `cards`
  ADD CONSTRAINT `FK_4C258FD7BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`);

--
-- Filtros para la tabla `cinemas`
--
ALTER TABLE `cinemas`
  ADD CONSTRAINT `FK_D7D63B9A3A5A5D4` FOREIGN KEY (`id_endereco_id`) REFERENCES `endereco` (`id`);

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `FK_50FE07D71BB76823` FOREIGN KEY (`endereco_id`) REFERENCES `endereco` (`id`),
  ADD CONSTRAINT `FK_50FE07D77EB2C349` FOREIGN KEY (`id_usuario_id`) REFERENCES `usuarios` (`id`);

--
-- Filtros para la tabla `filme`
--
ALTER TABLE `filme`
  ADD CONSTRAINT `FK_3A387F00C5C76018` FOREIGN KEY (`cinemas_id`) REFERENCES `cinemas` (`id`);

--
-- Filtros para la tabla `ingressos`
--
ALTER TABLE `ingressos`
  ADD CONSTRAINT `FK_8ED539D1B4CB84B6` FOREIGN KEY (`cinema_id`) REFERENCES `cinemas` (`id`),
  ADD CONSTRAINT `FK_8ED539D1C946E4F` FOREIGN KEY (`id_cadeira_id`) REFERENCES `cadeiras` (`id`),
  ADD CONSTRAINT `FK_8ED539D1DD4481AD` FOREIGN KEY (`id_order_id`) REFERENCES `order` (`id`);

--
-- Filtros para la tabla `ingressos_filme`
--
ALTER TABLE `ingressos_filme`
  ADD CONSTRAINT `FK_3F72F9C012373158` FOREIGN KEY (`ingressos_id`) REFERENCES `ingressos` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_3F72F9C0E6E418AD` FOREIGN KEY (`filme_id`) REFERENCES `filme` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `FK_F52993987BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`),
  ADD CONSTRAINT `FK_F5299398C3AEF485` FOREIGN KEY (`id_pagamento_id`) REFERENCES `pagamento` (`id`);

--
-- Filtros para la tabla `pagamento`
--
ALTER TABLE `pagamento`
  ADD CONSTRAINT `FK_3E1F4B167BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`);
  ADD CONSTRAINT `FK_3E1F4B16819793DF` FOREIGN KEY (`id_pim_coin_trans_id`) REFERENCES `pim_coin_trans` (`id`)

--
-- Filtros para la tabla `pim_coin`
--
ALTER TABLE `pim_coin`
  ADD CONSTRAINT `FK_AD584B107BF9CE86` FOREIGN KEY (`id_cliente_id`) REFERENCES `clientes` (`id`);

--
-- Filtros para la tabla `sala`
--
ALTER TABLE `sala`
  ADD CONSTRAINT `FK_E226041C34FE3891` FOREIGN KEY (`id_cinema_id`) REFERENCES `cinemas` (`id`);

ALTER TABLE `pim_coin_trans` 
  ADD CONSTRAINT FK_9F5709CC5A29E5 FOREIGN KEY (`pim_coin_id`) REFERENCES `pim_coin` (id)

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
