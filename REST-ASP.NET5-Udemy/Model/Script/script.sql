CREATE TABLE IF NOT EXISTS `person` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `endereco` varchar(100) NOT NULL,
  `primeiro_nome` varchar(80) NOT NULL,
  `sobrenome` varchar(80) NOT NULL,
  `genero` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id`)
) 