-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 17-05-2024 a las 18:57:17
-- Versión del servidor: 8.0.30
-- Versión de PHP: 8.3.2

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

CREATE TABLE `anotacion` (
  `idAnotacion` varchar(5) NOT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `cuerpo` text,
  `idMateria` varchar(5) DEFAULT NULL,
  `NombreMat` varchar(500) NOT NULL
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
-- Estructura de tabla para la tabla `conexion`
--

CREATE TABLE `conexion` (
  `idNodoOrigen` varchar(5) NOT NULL,
  `idNodoDestino` varchar(5) NOT NULL,
  `Peso` int DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dia_materia`
--

CREATE TABLE `dia_materia` (
  `id` int NOT NULL,
  `materia_id` varchar(5) DEFAULT NULL,
  `dia` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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

CREATE TABLE `materia` (
  `idMateria` varchar(5) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `horaClase` datetime DEFAULT NULL,
  `docente` varchar(255) DEFAULT NULL,
  `salon` varchar(255) DEFAULT NULL,
  `id_tarea` int DEFAULT NULL
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
-- Estructura de tabla para la tabla `nodo`
--

CREATE TABLE `nodo` (
  `idNodo` int NOT NULL,
  `tipo` int DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recordatorio`
--

CREATE TABLE `recordatorio` (
  `idRecordatorio` varchar(5) NOT NULL,
  `idNodo` varchar(10) DEFAULT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `fechaRecordatorio` datetime DEFAULT NULL,
  `cuerpo` varchar(500) DEFAULT NULL,
  `idMateria` varchar(5) DEFAULT NULL,
  `AnotacionR` varchar(500) NOT NULL,
  `MateriaR` varchar(500) NOT NULL,
  `TareaR` varchar(500) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `recordatorio`
--

INSERT INTO `recordatorio` (`idRecordatorio`, `idNodo`, `titulo`, `fechaRecordatorio`, `cuerpo`, `idMateria`, `AnotacionR`, `MateriaR`, `TareaR`) VALUES
('d4439', NULL, 'sasas', '2024-05-21 12:09:46', 'sasas', NULL, 'Proyecto', 'Quimica General', 'Hacer ejercicios'),
('9ef33', NULL, 'sasas', '2024-05-20 12:07:13', 'sasas', NULL, 'Laboratorio', 'Quimica General', 'Hacer ejercicios');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sistemametodosestudio`
--

CREATE TABLE `sistemametodosestudio` (
  `id` int NOT NULL,
  `id_tarea` int DEFAULT NULL,
  `id_metodo` int DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarea`
--

CREATE TABLE `tarea` (
  `id_tarea` varchar(5) NOT NULL,
  `fechaLimite` date DEFAULT NULL,
  `estadotarea` varchar(5000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `nombre` varchar(5000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `descripcion` text,
  `importancia` int NOT NULL,
  `AnotacionT` varchar(500) NOT NULL,
  `MateriaT` varchar(300) NOT NULL,
  `titulo` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tarea`
--

INSERT INTO `tarea` (`id_tarea`, `fechaLimite`, `estadotarea`, `nombre`, `descripcion`, `importancia`, `AnotacionT`, `MateriaT`, `titulo`) VALUES
('1', '2024-05-17', 'Importante', 'Quimica General', 'Importanteee', 0, 'MatLab', 'Quimica General', 'Hacer ejercicios'),
('2', '2024-06-04', 'Importante', 'Programación Estructurada', 'sasas', 0, 'Proyecto', 'Programación Estructurada', 'sasasas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `contrasena` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `nombre`, `contrasena`) VALUES
(1, 'PED', '1234');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `anotacion`
--
ALTER TABLE `anotacion`
  ADD PRIMARY KEY (`idAnotacion`),
  ADD KEY `fk_idMateria` (`idMateria`);

--
-- Indices de la tabla `conexion`
--
ALTER TABLE `conexion`
  ADD PRIMARY KEY (`idNodoOrigen`,`idNodoDestino`),
  ADD KEY `idNodoDestino` (`idNodoDestino`);

--
-- Indices de la tabla `dia_materia`
--
ALTER TABLE `dia_materia`
  ADD PRIMARY KEY (`id`),
  ADD KEY `materia_id` (`materia_id`);

--
-- Indices de la tabla `materia`
--
ALTER TABLE `materia`
  ADD PRIMARY KEY (`idMateria`),
  ADD KEY `fk_id_tarea` (`id_tarea`);

--
-- Indices de la tabla `nodo`
--
ALTER TABLE `nodo`
  ADD PRIMARY KEY (`idNodo`);

--
-- Indices de la tabla `recordatorio`
--
ALTER TABLE `recordatorio`
  ADD PRIMARY KEY (`idRecordatorio`),
  ADD UNIQUE KEY `UC_idNodo_recordatorio` (`idNodo`),
  ADD KEY `fk_idMateria` (`idMateria`);

--
-- Indices de la tabla `sistemametodosestudio`
--
ALTER TABLE `sistemametodosestudio`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_tarea` (`id_tarea`),
  ADD KEY `id_metodo` (`id_metodo`);

--
-- Indices de la tabla `tarea`
--
ALTER TABLE `tarea`
  ADD PRIMARY KEY (`id_tarea`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `dia_materia`
--
ALTER TABLE `dia_materia`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT de la tabla `sistemametodosestudio`
--
ALTER TABLE `sistemametodosestudio`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
