-- phpMyAdmin SQL Dump
-- version 4.4.15.9
-- https://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 31-05-2020 a las 16:36:51
-- Versión del servidor: 5.6.37
-- Versión de PHP: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `CinemasPIM`
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
) ENGINE=InnoDB AUTO_INCREMENT=6944 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `cards`
--

INSERT INTO `cards` (`id`, `id_cliente_id`, `nome`, `card_number`, `secure_number`) VALUES
(1, 2, 'Andres p', '0000000000000', '202cb962ac59075b964b07152d234b70');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cinemas`
--

CREATE TABLE IF NOT EXISTS `cinemas` (
  `id` int(11) NOT NULL,
  `id_endereco_id` int(11) NOT NULL,
  `nome` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `cinemas`
--

INSERT INTO `cinemas` (`id`, `id_endereco_id`, `nome`) VALUES
(1, 3, 'Amazonas shopping'),
(2, 4, 'Ponta Negra Shopping'),
(3, 5, 'Millennium Shopping'),
(4, 6, 'Sumaúma Park Shopping');

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `endereco_id`, `cpf`, `telefone`, `use_card`, `use_pimcoin`, `id_usuario_id`) VALUES
(2, 2, '70966225-025', '92984240045', 1, NULL, 1),
(3, 7, '123456789-22', '9298456632', NULL, 1, 2)

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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `endereco`
--

INSERT INTO `endereco` (`id`, `rua`, `cidade`, `estado`, `cpe`) VALUES
(2, 'Djalma', 'manaus', 'Amazonas', '690-035'),
(3, 'Av. Djalma Batista', 'Manaus', 'Amazonas ', '69050-010'),
(4, 'Av. Coronel Teixeira', 'Manaus', 'Amazonas ', '69037-000'),
(5, 'Av. Djalma Batista', 'Manaus', 'Amazonas ', '69050-015'),
(6, 'Av. Noel Nutels', 'Manaus', 'Amazonas', '69095-000'),
(7, 'Djalma Batista', 'Manaus', 'Amazonas', '69005-035'),
(8, 'san luis', 'caracas', 'miranda', '0000-000'),
(9, 'djlama', 'manaus', 'Amazonas', '00000-00'),
(10, 'djalma', 'manaus', 'amazonas', '0000-00'),
(11, 'mindu', 'manaus', 'Amazonas', '112345-035');

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
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `filme`
--

INSERT INTO `filme` (`id`, `cinemas_id`, `titulo`, `categorias`, `duration`, `ano_estreia`, `rating`) VALUES
(1, 1, 'Mulan', 'Aventuras, drama, acción y cine bélico', '1 hora y media', 2020, 3),
(2, 1, 'Presencias del mal', 'terror, drama, acción', '1 hora y media', 2020, 3),
(3, 1, 'Dolittle', 'Aventuras, fantasía, comedia y cine familiar', '1 hora y 45 minutos ', 2020, 2),
(4, 1, 'Godzilla vs Kong', 'Suspenso, acción y ciencia ficción', '1 hora y 30 minutos', 2020, 1),
(5, 1, 'Terremoto', 'acción, drama, suspenso', '1 hora y 30 minutos', 1974, 1),
(6, 1, 'Predestinado', 'Ciencia ficción, drama, cine de suspenso, cine LGBT y cine distópico', '1 hora y 30 minutos', 2014, 3),
(7, 2, 'Mulan', 'Aventuras, drama, acción y cine bélico', '1 hora y media', 2020, 3),
(8, 2, 'Presencias del mal', 'terror, drama, acción', '1 hora y media', 2020, 3),
(9, 2, 'Dolittle', 'Aventuras, fantasía, comedia y cine familiar', '1 hora y 45 minutos ', 2020, 2),
(10, 2, 'Godzilla vs Kong', 'Suspenso, acción y ciencia ficción', '1 hora y 30 minutos', 2020, 1),
(11, 2, 'Terremoto', 'acción, drama, suspenso', '1 hora y 30 minutos', 1974, 1),
(12, 2, 'Predestinado', 'Ciencia ficción, drama, cine de suspenso, cine LGBT y cine distópico', '1 hora y 30 minutos', 2014, 3),
(13, 3, 'Mulan', 'Aventuras, drama, acción y cine bélico', '1 hora y media', 2020, 3),
(14, 3, 'Presencias del mal', 'terror, drama, acción', '1 hora y media', 2020, 3),
(15, 3, 'Dolittle', 'Aventuras, fantasía, comedia y cine familiar', '1 hora y 45 minutos ', 2020, 2),
(16, 3, 'Godzilla vs Kong', 'Suspenso, acción y ciencia ficción', '1 hora y 30 minutos', 2020, 1),
(17, 3, 'Terremoto', 'acción, drama, suspenso', '1 hora y 30 minutos', 1974, 1),
(18, 3, 'Predestinado', 'Ciencia ficción, drama, cine de suspenso, cine LGBT y cine distópico', '1 hora y 30 minutos', 2014, 3),
(19, 4, 'Mulan', 'Aventuras, drama, acción y cine bélico', '1 hora y media', 2020, 3),
(20, 4, 'Presencias del mal', 'terror, drama, acción', '1 hora y media', 2020, 3),
(21, 4, 'Dolittle', 'Aventuras, fantasía, comedia y cine familiar', '1 hora y 45 minutos ', 2020, 2),
(22, 4, 'Godzilla vs Kong', 'Suspenso, acción y ciencia ficción', '1 hora y 30 minutos', 2020, 1),
(23, 4, 'Terremoto', 'acción, drama, suspenso', '1 hora y 30 minutos', 1974, 1),
(24, 4, 'Predestinado', 'Ciencia ficción, drama, cine de suspenso, cine LGBT y cine distópico', '1 hora y 30 minutos', 2014, 3);

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
) ENGINE=InnoDB AUTO_INCREMENT=9997 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
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

--
-- Volcado de datos para la tabla `migration_versions`
--

INSERT INTO `migration_versions` (`version`, `executed_at`) VALUES
('20200519015740', '2020-05-19 02:02:28'),
('20200519022117', '2020-05-19 02:23:43'),
('20200524144942', '2020-05-24 14:53:38'),
('20200525182159', '2020-05-25 18:22:41'),
('20200527031104', '2020-05-27 03:12:16');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `id` int(11) NOT NULL,
  `id_pagamento_id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11942 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagamento`
--

CREATE TABLE IF NOT EXISTS `pagamento` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) DEFAULT NULL,
  `use_pimcoin` tinyint(1) DEFAULT NULL,
  `use_card` tinyint(1) DEFAULT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10942 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pim_coin`
--

CREATE TABLE IF NOT EXISTS `pim_coin` (
  `id` int(11) NOT NULL,
  `id_cliente_id` int(11) NOT NULL,
  `private_key_user` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `pim_coin`
--

INSERT INTO `pim_coin` (`id`, `id_cliente_id`, `private_key_user`) VALUES
(1, 3, 'ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAACAQDbY0e2SPFz3U4s80tPTtOlM4N9Qbev7fGzpfKgFPLKM9Unj0VqzkXNpc5rGo5xmaMeZkASzw0ECGgeU0xsqrWBFyBNb3uQJVi8AQi/lB8eVPNC+iRmiRwAsSKKoSc32lbzwRyGjWgzLKhF4B2Ll5TNDALPIbL8AVkvjP4vMNsYvd3sGonVWlYQ58bdNX55w3GnSYR2MH8/+S3wCwL2HOXa9nJDTTOVEJmAKF6Ocl+/QTTBwDDnA17P3McTJF+jMKC4uNHk8EPiv/oc9n9HR673HJqZFhko/Mo3NiJMeLgTFOxMrXgaDeRvHAytbqZ6gM94pE5BtSdvKwEEUKcy0AmxOi4a+7SfFhkS2GP1zMfdc3UdtjhILl9xd6THlx62O6rqegVJXQ21cpHKcPzWqxfwEtRIhAf79KWYLN9nXnvlH1PZm484Q0BgvIVuhjFwYjR2KF6yRkhy0ZlObgYJ1o8AbIbzs7ei+PkJQrS+W4DwCUqxIG0UC4KOaf4+lwnA0Z+eE37IzTos7BqUWBFHkGiJDVxmc2MXWnqj2UsImlV2DkRBDcw31C5E63wd8BU/3PMvkwrtCnSrRTGcApH1pnun/BP75RD5v9WSfQ8PNk14sGQZToL6b44ImvirkEUUdHcHqzF/bEB9omnZv/yPsi/VOQfJjtEbCaj/GSJgYFlmGw== dummy@example.com\r\n');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `id` int(11) NOT NULL,
  `id_cinema_id` int(11) NOT NULL,
  `horarios` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `sala`
--

INSERT INTO `sala` (`id`, `id_cinema_id`, `horarios`) VALUES
(1, 1, '1:00-3:00'),
(2, 1, '3:30-5:30'),
(3, 1, '7:00-9:00'),
(4, 1, '9:30-11:30'),
(5, 2, '1:00-3:00'),
(6, 2, '3:30-5:30'),
(7, 2, '7:00-9:00'),
(8, 2, '9:30-11:30'),
(9, 3, '1:00-3:00'),
(10, 3, '3:30-5:30'),
(11, 3, '7:00-9:00'),
(12, 3, '9:30-11:30'),
(13, 4, '1:00-3:00'),
(16, 4, '3:30-5:30'),
(17, 4, '7:00-9:00'),
(18, 4, '9:30-11:30');

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `password`, `admin`) VALUES
(1, 'Andres', 'a2payema@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', NULL),
(2, 'Diego', 'diegopayema@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', NULL),
(3, 'Admin', 'admin@dev.com', 'e10adc3949ba59abbe56e057f20f883e', 1)

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6944;
--
-- AUTO_INCREMENT de la tabla `cards`
--
ALTER TABLE `cards`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `endereco`
--
ALTER TABLE `endereco`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `filme`
--
ALTER TABLE `filme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT de la tabla `ingressos`
--
ALTER TABLE `ingressos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9997;
--
-- AUTO_INCREMENT de la tabla `order`
--
ALTER TABLE `order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11942;
--
-- AUTO_INCREMENT de la tabla `pagamento`
--
ALTER TABLE `pagamento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10942;
--
-- AUTO_INCREMENT de la tabla `pim_coin`
--
ALTER TABLE `pim_coin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `sala`
--
ALTER TABLE `sala`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
