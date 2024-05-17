-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 17-05-2024 a las 14:14:58
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
(13, 'MC616', 'Lunes');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `dia_materia`
--
ALTER TABLE `dia_materia`
  ADD PRIMARY KEY (`id`),
  ADD KEY `materia_id` (`materia_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `dia_materia`
--
ALTER TABLE `dia_materia`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
