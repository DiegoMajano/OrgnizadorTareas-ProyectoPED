-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 17-05-2024 a las 18:14:05
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `catedraped`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `anotacion`
--

DROP TABLE IF EXISTS `anotacion`;
CREATE TABLE IF NOT EXISTS `anotacion` (
  `idAnotacion` varchar(5) NOT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `cuerpo` text,
  `idMateria` varchar(5) DEFAULT NULL,
  `NombreMat` varchar(500) NOT NULL,
  PRIMARY KEY (`idAnotacion`),
  KEY `fk_idMateria` (`idMateria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `anotacion`
--

INSERT INTO `anotacion` (`idAnotacion`, `titulo`, `cuerpo`, `idMateria`, `NombreMat`) VALUES
('AM810', 'MatLab', 'Para realizar los laboratorios de Cálculo Diferencial se utiliza MatLab, se debe estudiar sobre la sintaxis que se utiliza en la aplicación', NULL, 'Cálculo Diferencial'),
('AP517', 'Proyecto', 'Repartir al grupo de proyecto los apartados que se deben de realizar', NULL, 'Programación Estructurada'),
('AL111', 'Laboratorio', 'Para los laboratorios se deben realizar una hoja de papel con el resumen y pasos de la practica a realizar en el laboratorio', NULL, 'Quimica General'),
('AR502', 'Reglas de integración', 'Ver y descargar el archivo de las reglas de integracion del aula, estudiarlas y aprenderlas', NULL, 'Cálculo Integral'),
('AP345', 'PRUEB', 'prueba', '', 'Comunicación Oral y Escrita');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dia_materia`
--

DROP TABLE IF EXISTS `dia_materia`;
CREATE TABLE IF NOT EXISTS `dia_materia` (
  `id` int NOT NULL AUTO_INCREMENT,
  `materia_id` varchar(5) DEFAULT NULL,
  `dia` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `materia_id` (`materia_id`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `dia_materia`
--

INSERT INTO `dia_materia` (`id`, `materia_id`, `dia`) VALUES
(18, 'MP999', 'Miércoles'),
(17, 'MQ443', 'Jueves'),
(16, 'MQ443', 'Martes'),
(15, 'MC616', 'Viernes'),
(14, 'MC616', 'Miércoles'),
(13, 'MC616', 'Lunes'),
(20, 'MC987', 'Sábado'),
(21, 'MC987', 'Martes'),
(22, 'MC987', 'Jueves'),
(24, 'MP999', 'Lunes'),
(25, 'MC570', 'Lunes'),
(26, 'MC570', 'Miércoles');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia`
--

DROP TABLE IF EXISTS `materia`;
CREATE TABLE IF NOT EXISTS `materia` (
  `idMateria` varchar(5) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `horaClase` datetime DEFAULT NULL,
  `docente` varchar(255) DEFAULT NULL,
  `salon` varchar(255) DEFAULT NULL,
  `id_tarea` int DEFAULT NULL,
  PRIMARY KEY (`idMateria`),
  KEY `fk_id_tarea` (`id_tarea`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `materia`
--

INSERT INTO `materia` (`idMateria`, `nombre`, `horaClase`, `docente`, `salon`, `id_tarea`) VALUES
('MP999', 'Programación Estructurada', '2024-05-17 11:10:00', 'Ing Melvin', '6-22', NULL),
('MQ443', 'Quimica General', '2024-05-17 09:05:00', 'Ing Francisco Merino', 'C35', NULL),
('MC616', 'Cálculo Diferencial', '2024-05-17 07:00:00', 'Lic Glenda', 'C24', NULL),
('MC987', 'Cinematica y Dinámica de Particulas', '2024-05-17 11:10:00', 'Ing Francisco', 'C34', NULL),
('MC570', 'Cálculo Integral', '2024-05-17 11:10:00', 'Lic Karen', 'C24', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recordatorio`
--

DROP TABLE IF EXISTS `recordatorio`;
CREATE TABLE IF NOT EXISTS `recordatorio` (
  `idRecordatorio` varchar(5) NOT NULL,
  `idNodo` varchar(10) DEFAULT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `fechaRecordatorio` datetime DEFAULT NULL,
  `cuerpo` varchar(500) DEFAULT NULL,
  `idMateria` varchar(5) DEFAULT NULL,
  `AnotacionR` varchar(500) NOT NULL,
  `MateriaR` varchar(500) NOT NULL,
  `TareaR` varchar(500) NOT NULL,
  PRIMARY KEY (`idRecordatorio`),
  UNIQUE KEY `UC_idNodo_recordatorio` (`idNodo`),
  KEY `fk_idMateria` (`idMateria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `recordatorio`
--

INSERT INTO `recordatorio` (`idRecordatorio`, `idNodo`, `titulo`, `fechaRecordatorio`, `cuerpo`, `idMateria`, `AnotacionR`, `MateriaR`, `TareaR`) VALUES
('d4439', NULL, 'sasas', '2024-05-21 12:09:46', 'sasas', NULL, 'Proyecto', 'Quimica General', 'Hacer ejercicios'),
('9ef33', NULL, 'sasas', '2024-05-20 12:07:13', 'sasas', NULL, 'Laboratorio', 'Quimica General', 'Hacer ejercicios');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarea`
--

DROP TABLE IF EXISTS `tarea`;
CREATE TABLE IF NOT EXISTS `tarea` (
  `id_tarea` int NOT NULL AUTO_INCREMENT,
  `fechaLimite` date DEFAULT NULL,
  `estadotarea` varchar(5000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `nombre` varchar(5000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `descripcion` text,
  `AnotacionT` varchar(500) NOT NULL,
  `MateriaT` varchar(300) NOT NULL,
  `titulo` varchar(500) NOT NULL,
  PRIMARY KEY (`id_tarea`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tarea`
--

INSERT INTO `tarea` (`id_tarea`, `fechaLimite`, `estadotarea`, `nombre`, `descripcion`, `AnotacionT`, `MateriaT`, `titulo`) VALUES
(1, '2024-05-17', 'Importante', 'Quimica General', 'Importanteee', 'MatLab', 'Quimica General', 'Hacer ejercicios'),
(2, '2024-06-04', 'Importante', 'Programación Estructurada', 'sasas', 'Proyecto', 'Programación Estructurada', 'sasasas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `contrasena` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `nombre`, `contrasena`) VALUES
(1, 'PED', '1234');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
