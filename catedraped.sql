-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 17-05-2024 a las 02:51:03
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
  `idAnotacion` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(255) DEFAULT NULL,
  `cuerpo` text,
  `idMateria` int DEFAULT NULL,
  `NombreMat` varchar(500) NOT NULL,
  PRIMARY KEY (`idAnotacion`),
  KEY `fk_idMateria` (`idMateria`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `anotacion`
--

INSERT INTO `anotacion` (`idAnotacion`, `titulo`, `cuerpo`, `idMateria`, `NombreMat`) VALUES
(5, 'ddd', 'ddd', NULL, 'Anatomia'),
(4, 'Recordar Tarea', 'porfaaa', NULL, 'MATE'),
(6, 'sss', 'sss', NULL, 'Bio'),
(7, 'xxxx', 'xzxzxzx', NULL, 'MATE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conexion`
--

DROP TABLE IF EXISTS `conexion`;
CREATE TABLE IF NOT EXISTS `conexion` (
  `idNodoOrigen` int NOT NULL,
  `idNodoDestino` int NOT NULL,
  `Peso` int DEFAULT NULL,
  PRIMARY KEY (`idNodoOrigen`,`idNodoDestino`),
  KEY `idNodoDestino` (`idNodoDestino`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia`
--

DROP TABLE IF EXISTS `materia`;
CREATE TABLE IF NOT EXISTS `materia` (
  `idMateria` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `horaClase` datetime DEFAULT NULL,
  `docente` varchar(255) DEFAULT NULL,
  `salon` varchar(255) DEFAULT NULL,
  `id_tarea` int DEFAULT NULL,
  `dias` varchar(5000) NOT NULL,
  PRIMARY KEY (`idMateria`),
  KEY `fk_id_tarea` (`id_tarea`)
) ENGINE=MyISAM AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `materia`
--

INSERT INTO `materia` (`idMateria`, `nombre`, `horaClase`, `docente`, `salon`, `id_tarea`, `dias`) VALUES
(1, 'Bio', '2024-05-15 09:05:00', 'william', 'A35', NULL, ''),
(2, 'MATE', '2024-05-15 11:10:00', 'Adriana Hasbun', 'A12', NULL, ''),
(18, 'Anatomia', '2024-05-15 11:10:00', 'Nicole', 'B21', NULL, ''),
(38, 'Fisica', '2024-05-16 15:20:00', 'Wilfredito', 'b21', NULL, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nodo`
--

DROP TABLE IF EXISTS `nodo`;
CREATE TABLE IF NOT EXISTS `nodo` (
  `idNodo` int NOT NULL,
  `tipo` int DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idNodo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recordatorio`
--

DROP TABLE IF EXISTS `recordatorio`;
CREATE TABLE IF NOT EXISTS `recordatorio` (
  `idRecordatorio` int NOT NULL,
  `idNodo` varchar(10) DEFAULT NULL,
  `idUsuario` int DEFAULT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `arecordar` datetime DEFAULT NULL,
  `idMateria` int DEFAULT NULL,
  PRIMARY KEY (`idRecordatorio`),
  UNIQUE KEY `UC_idNodo_recordatorio` (`idNodo`),
  KEY `idUsuario` (`idUsuario`),
  KEY `fk_idMateria` (`idMateria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sistemametodosestudio`
--

DROP TABLE IF EXISTS `sistemametodosestudio`;
CREATE TABLE IF NOT EXISTS `sistemametodosestudio` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_tarea` int DEFAULT NULL,
  `id_metodo` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_tarea` (`id_tarea`),
  KEY `id_metodo` (`id_metodo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
) ;

--
-- Volcado de datos para la tabla `tarea`
--

INSERT INTO `tarea` (`id_tarea`, `fechaLimite`, `estadotarea`, `nombre`, `descripcion`, `AnotacionT`, `MateriaT`, `titulo`) VALUES
(1, '2024-05-14', NULL, 'Bio', 'dsdsd', '', 'Bio', 'dsdsd'),
(2, '2024-05-09', 'Muy importante', 'Anatomia', 'sasas', 'Recordar Tarea', 'Anatomia', 'zsasas'),
(3, '2024-05-20', 'No importante', 'MATE', 'ssasas', 'ddd', 'MATE', 'ssss'),
(4, '2024-05-21', 'Importante', 'MATE', 'holaaa', 'Recordar Tarea', 'MATE', 'prueba');

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
