-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Mar 16 Avril 2013 à 13:35
-- Version du serveur: 5.5.24-log
-- Version de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `bd_scolaire`
--

-- --------------------------------------------------------

--
-- Structure de la table `classe`
--

CREATE TABLE IF NOT EXISTS `classe` (
  `NumClasse` int(11) NOT NULL AUTO_INCREMENT,
  `Classe` varchar(19) COLLATE latin1_general_cs NOT NULL,
  PRIMARY KEY (`NumClasse`),
  KEY `NumClasse` (`NumClasse`),
  KEY `NumClasse_2` (`NumClasse`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs AUTO_INCREMENT=9 ;

--
-- Contenu de la table `classe`
--

INSERT INTO `classe` (`NumClasse`, `Classe`) VALUES
(1, 'Petite section'),
(2, 'Moyenne section'),
(3, 'Grande section'),
(4, 'CP'),
(5, 'CE1'),
(6, 'CE2'),
(7, 'CM1'),
(8, 'CM2');

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE IF NOT EXISTS `eleve` (
  `NumEleve` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` text COLLATE latin1_general_cs NOT NULL,
  `Prenom` text COLLATE latin1_general_cs NOT NULL,
  `DateNaissance` text COLLATE latin1_general_cs NOT NULL,
  `NumClasse` int(11) NOT NULL,
  `Adresse 1` text COLLATE latin1_general_cs NOT NULL,
  `Adresse 2` text COLLATE latin1_general_cs,
  `Ville 1` text COLLATE latin1_general_cs NOT NULL,
  `Ville 2` text COLLATE latin1_general_cs,
  `CP1` text COLLATE latin1_general_cs NOT NULL,
  `CP2` text COLLATE latin1_general_cs,
  `Tel` text COLLATE latin1_general_cs NOT NULL,
  PRIMARY KEY (`NumEleve`),
  KEY `NumEleve` (`NumEleve`),
  KEY `Classe` (`NumClasse`),
  KEY `Classe_2` (`NumClasse`),
  KEY `Classe_4` (`NumClasse`),
  KEY `NumClasse` (`NumClasse`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs AUTO_INCREMENT=7 ;

--
-- Contenu de la table `eleve`
--

INSERT INTO `eleve` (`NumEleve`, `Nom`, `Prenom`, `DateNaissance`, `NumClasse`, `Adresse 1`, `Adresse 2`, `Ville 1`, `Ville 2`, `CP1`, `CP2`, `Tel`) VALUES
(6, 'fesfsefze', 'fzefze', 'mardi 16 avril 2013', 4, 'zefze', NULL, 'zefzefezf', '', 'fzef', NULL, 'zefzefez');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD CONSTRAINT `eleve_ibfk_1` FOREIGN KEY (`NumClasse`) REFERENCES `classe` (`NumClasse`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
