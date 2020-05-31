INSERT INTO `migration_versions` (`version`, `executed_at`) VALUES
('20200519015740', '2020-05-19 02:02:28'),
('20200519022117', '2020-05-19 02:23:43'),
('20200524144942', '2020-05-24 14:53:38'),
('20200525182159', '2020-05-25 18:22:41'),
('20200527031104', '2020-05-27 03:12:16');


INSERT INTO `usuarios` (`id`, `nome`, `email`, `password`, `admin`) VALUES
(1, 'Andres', 'a2payema@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', NULL),
(2, 'Diego', 'diegopayema@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', NULL),
(3, 'Andres', 'andresp@dev.com', '670b14728ad9902aecba32e22fa4f6bd', 1)


INSERT INTO `clientes` (`id`, `endereco_id`, `cpf`, `telefone`, `use_card`, `use_pimcoin`, `id_usuario_id`) VALUES
(2, 2, '70966225-025', '92984240045', null, NULL, 1),
(3, 7, '123456789-22', '9298456632', NULL, null, 2)



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

INSERT INTO `cinemas` (`id`, `id_endereco_id`, `nome`) VALUES
(1, 3, 'Amazonas shopping'),
(2, 4, 'Ponta Negra Shopping'),
(3, 5, 'Millennium Shopping'),
(4, 6, 'Sumaúma Park Shopping');


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