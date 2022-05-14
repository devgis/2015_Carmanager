/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : db_carmanager

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-26 20:49:15
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `t_car`
-- ----------------------------
DROP TABLE IF EXISTS `t_car`;
CREATE TABLE `t_car` (
  `id` varchar(40) NOT NULL,
  `memberid` varchar(40) DEFAULT NULL,
  `trademark` varchar(40) NOT NULL,
  `color` varchar(20) NOT NULL,
  `typeid` varchar(40) NOT NULL,
  `parkingtype` varchar(20) NOT NULL,
  `carno` varchar(20) DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_car
-- ----------------------------
INSERT INTO `t_car` VALUES ('9269dc27-5fc6-442d-b953-c7260b5f17d8', '242b9721-6222-4bcb-874e-7f8ec67cc80f', '大众保时捷', '红色33', 'a8442a27-1d43-40df-b073-ac603861a151', '包月', '山A23392', 'cc3332');

-- ----------------------------
-- Table structure for `t_carblacklist`
-- ----------------------------
DROP TABLE IF EXISTS `t_carblacklist`;
CREATE TABLE `t_carblacklist` (
  `id` varchar(40) NOT NULL,
  `carno` varchar(40) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_carblacklist
-- ----------------------------
INSERT INTO `t_carblacklist` VALUES ('f3a3e8e1-e305-429a-91ae-7f48465322a8', '京C39239');

-- ----------------------------
-- Table structure for `t_cartype`
-- ----------------------------
DROP TABLE IF EXISTS `t_cartype`;
CREATE TABLE `t_cartype` (
  `id` varchar(40) NOT NULL,
  `typename` varchar(40) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_cartype
-- ----------------------------
INSERT INTO `t_cartype` VALUES ('a8442a27-1d43-40df-b073-ac603861a151', ' 测试类型');

-- ----------------------------
-- Table structure for `t_chargerule`
-- ----------------------------
DROP TABLE IF EXISTS `t_chargerule`;
CREATE TABLE `t_chargerule` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `starthour` decimal(10,0) NOT NULL,
  `startmonyhour` decimal(10,0) NOT NULL,
  `endmonyhour` decimal(10,0) NOT NULL,
  `maxmoney` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_chargerule
-- ----------------------------
INSERT INTO `t_chargerule` VALUES ('86df0461-29ba-4148-a40e-8794a38097cb', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '3', '3', '20', '10000');
INSERT INTO `t_chargerule` VALUES ('default', 'default', '2', '2', '2', '9990');

-- ----------------------------
-- Table structure for `t_coupons`
-- ----------------------------
DROP TABLE IF EXISTS `t_coupons`;
CREATE TABLE `t_coupons` (
  `id` varchar(40) NOT NULL,
  `totalamount` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `createtime` datetime DEFAULT NULL,
  `state` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_coupons
-- ----------------------------

-- ----------------------------
-- Table structure for `t_dutylog`
-- ----------------------------
DROP TABLE IF EXISTS `t_dutylog`;
CREATE TABLE `t_dutylog` (
  `id` varchar(40) NOT NULL,
  `operatorid` varchar(40) NOT NULL,
  `dutytype` varchar(20) NOT NULL,
  `dutytime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_dutylog
-- ----------------------------
INSERT INTO `t_dutylog` VALUES ('0b49de3d-a48c-494e-aa51-f085f9d04a72', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-23 19:47:11');
INSERT INTO `t_dutylog` VALUES ('19657a9d-c80e-4e0f-9cf8-132ac9a187c8', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 19:54:47');
INSERT INTO `t_dutylog` VALUES ('1ae26fc8-6d5c-41be-817b-567442813d57', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-22 23:25:18');
INSERT INTO `t_dutylog` VALUES ('222', '1', '接班', '2015-10-08 20:43:45');
INSERT INTO `t_dutylog` VALUES ('3100b7fe-5662-4244-a7a3-ff51cd1bb4dd', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-22 22:59:52');
INSERT INTO `t_dutylog` VALUES ('463e1ecb-d8e9-4fee-88aa-3f55c0492da8', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 22:02:32');
INSERT INTO `t_dutylog` VALUES ('640805c8-c0aa-4ad7-a50d-dc8513eb638d', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 21:24:39');
INSERT INTO `t_dutylog` VALUES ('77f3d9e9-102e-4f7b-accf-364291d8189f', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 19:55:17');
INSERT INTO `t_dutylog` VALUES ('7bfccf7e-2b55-422e-9419-c8e27a57ce10', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '下班', '2015-10-22 23:25:28');
INSERT INTO `t_dutylog` VALUES ('7fab4719-8485-4473-8b9c-9976ecdf40a3', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 21:25:35');
INSERT INTO `t_dutylog` VALUES ('7fdebc0f-929f-4842-b2f3-684cc8bb0be8', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-23 20:52:00');
INSERT INTO `t_dutylog` VALUES ('8397db72-85a7-4ed3-af13-eb0bf29423b2', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-22 23:25:36');
INSERT INTO `t_dutylog` VALUES ('88a1020a-f9ad-40d8-a534-6b611956b507', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-26 20:46:55');
INSERT INTO `t_dutylog` VALUES ('92e04e95-210d-4e49-afc5-c10ca7f476d4', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-26 20:44:07');
INSERT INTO `t_dutylog` VALUES ('98ddb524-cd53-4345-a69f-9ba22aaa1e9b', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 21:28:14');
INSERT INTO `t_dutylog` VALUES ('9cb9bdcb-f4cf-405d-9f39-8d3a5a98dd6b', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-22 23:16:02');
INSERT INTO `t_dutylog` VALUES ('aa7d6fcf-d95b-4561-ab2c-c9eff2b16aa7', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-26 20:43:37');
INSERT INTO `t_dutylog` VALUES ('b27ef4bc-d597-4d96-81d7-055b78b47c59', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-25 12:17:29');
INSERT INTO `t_dutylog` VALUES ('c2258a96-5608-4598-9fb5-c8c607c75c8c', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 20:28:47');
INSERT INTO `t_dutylog` VALUES ('c6058c9e-f114-4597-b578-519b3cad2d06', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 21:57:07');
INSERT INTO `t_dutylog` VALUES ('c6cd7759-3c84-4894-9bf8-51daea8d7cc2', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-24 20:25:08');
INSERT INTO `t_dutylog` VALUES ('d8e3713b-8d2e-4460-8120-7f3c8bc94a6a', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-26 20:36:32');
INSERT INTO `t_dutylog` VALUES ('ef1e07d4-0f39-412a-ad4c-acf043ccd89e', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-26 20:48:52');
INSERT INTO `t_dutylog` VALUES ('f7eb6f53-818d-4e5a-b9ca-cf46f55d9e48', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '上班', '2015-10-25 12:49:26');

-- ----------------------------
-- Table structure for `t_equipment`
-- ----------------------------
DROP TABLE IF EXISTS `t_equipment`;
CREATE TABLE `t_equipment` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `sentryboxid` varchar(40) NOT NULL,
  `name` varchar(40) NOT NULL,
  `connectinfo` varchar(40) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_equipment
-- ----------------------------
INSERT INTO `t_equipment` VALUES ('0e3fdaf0-57bc-4227-91c3-e25143718dcf', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '测试设备', '测试链接信息');
INSERT INTO `t_equipment` VALUES ('960f5e5b-6f79-4e3a-9c88-4737b3b10e79', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '1132', 'wed');

-- ----------------------------
-- Table structure for `t_log`
-- ----------------------------
DROP TABLE IF EXISTS `t_log`;
CREATE TABLE `t_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `logtime` datetime DEFAULT NULL,
  `operatorid` varchar(40) DEFAULT NULL,
  `content` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=110 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_log
-- ----------------------------
INSERT INTO `t_log` VALUES ('1', '2015-10-05 14:48:29', '6ddf7770-66a0-47e8-898f-c7ac9ebe99ef', '创建了系统');
INSERT INTO `t_log` VALUES ('2', '2015-10-14 19:47:58', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('3', '2015-10-14 19:49:14', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('4', '2015-10-14 20:20:49', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('5', '2015-10-14 21:08:42', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('6', '2015-10-14 21:11:21', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('7', '2015-10-14 21:13:07', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('8', '2015-10-14 21:14:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('9', '2015-10-14 21:15:16', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('10', '2015-10-14 21:16:06', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('11', '2015-10-14 21:16:56', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('12', '2015-10-14 21:43:08', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('13', '2015-10-14 21:44:42', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('14', '2015-10-14 21:46:24', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('15', '2015-10-14 21:47:30', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('16', '2015-10-14 21:48:29', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('17', '2015-10-14 21:49:07', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('18', '2015-10-14 23:07:29', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('19', '2015-10-14 23:08:13', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('20', '2015-10-14 23:11:07', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('21', '2015-10-14 23:12:30', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('22', '2015-10-14 23:13:22', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('23', '2015-10-14 23:16:20', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('24', '2015-10-14 23:17:34', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('25', '2015-10-14 23:18:43', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('26', '2015-10-14 23:20:47', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('27', '2015-10-14 23:22:37', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('28', '2015-10-14 23:24:42', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('29', '2015-10-15 21:43:03', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('30', '2015-10-15 22:20:11', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('31', '2015-10-17 10:41:57', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('32', '2015-10-17 11:16:32', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('33', '2015-10-17 12:03:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('34', '2015-10-17 12:03:49', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('35', '2015-10-17 12:04:22', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('36', '2015-10-17 13:04:59', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('37', '2015-10-17 13:06:44', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('38', '2015-10-17 13:09:22', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('39', '2015-10-17 13:15:39', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('40', '2015-10-17 13:16:39', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('41', '2015-10-17 13:17:48', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('42', '2015-10-17 13:19:23', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('43', '2015-10-17 13:21:02', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('44', '2015-10-17 13:21:47', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('45', '2015-10-17 13:23:22', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('46', '2015-10-17 13:24:53', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('47', '2015-10-17 13:28:23', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('48', '2015-10-17 13:32:09', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('49', '2015-10-17 13:33:27', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('50', '2015-10-17 13:34:02', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('51', '2015-10-17 13:35:03', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('52', '2015-10-17 13:36:18', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('53', '2015-10-17 15:11:43', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('54', '2015-10-17 15:53:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('55', '2015-10-17 15:59:18', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('56', '2015-10-17 16:01:59', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('57', '2015-10-17 16:16:43', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('58', '2015-10-17 16:19:26', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('59', '2015-10-17 16:21:08', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('60', '2015-10-17 16:23:11', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('61', '2015-10-17 18:59:54', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('62', '2015-10-17 19:06:33', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('63', '2015-10-17 19:21:22', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('64', '2015-10-17 19:22:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('65', '2015-10-17 21:18:04', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('66', '2015-10-17 21:59:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('67', '2015-10-17 22:02:36', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('68', '2015-10-17 22:04:25', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('69', '2015-10-17 22:05:47', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('70', '2015-10-17 22:07:01', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('71', '2015-10-17 22:07:17', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('72', '2015-10-18 22:25:17', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('73', '2015-10-19 20:00:55', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('74', '2015-10-19 20:17:52', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('75', '2015-10-19 20:20:41', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('76', '2015-10-19 20:21:12', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('77', '2015-10-19 20:40:56', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('78', '2015-10-19 20:48:34', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('79', '2015-10-19 21:04:05', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('80', '2015-10-19 21:06:07', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('81', '2015-10-19 21:12:21', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('82', '2015-10-19 21:12:45', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('83', '2015-10-19 21:23:43', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('84', '2015-10-19 21:52:26', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('85', '2015-10-19 21:53:40', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('86', '2015-10-19 21:54:38', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('87', '2015-10-19 22:44:30', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('88', '2015-10-19 22:56:53', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('89', '2015-10-19 22:57:30', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('90', '2015-10-19 22:59:59', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('91', '2015-10-19 23:01:52', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('92', '2015-10-19 23:03:27', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('93', '2015-10-19 23:04:21', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('94', '2015-10-19 23:15:07', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('95', '2015-10-19 23:16:17', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('96', '2015-10-19 23:16:33', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('97', '2015-10-20 22:00:38', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('98', '2015-10-20 22:04:45', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('99', '2015-10-20 22:09:19', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('100', '2015-10-20 22:11:17', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('101', '2015-10-20 22:23:54', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('102', '2015-10-20 22:49:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('103', '2015-10-25 12:18:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('104', '2015-10-25 12:19:05', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('105', '2015-10-25 12:21:00', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('106', '2015-10-25 12:51:43', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('107', '2015-10-25 13:04:17', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('108', '2015-10-25 13:05:34', '1', '登陆系统');
INSERT INTO `t_log` VALUES ('109', '2015-10-25 13:07:42', '1', '登陆系统');

-- ----------------------------
-- Table structure for `t_member`
-- ----------------------------
DROP TABLE IF EXISTS `t_member`;
CREATE TABLE `t_member` (
  `id` varchar(40) NOT NULL,
  `loginname` varchar(40) NOT NULL,
  `realname` varchar(20) NOT NULL,
  `idcard` varchar(20) DEFAULT NULL,
  `mobile` varchar(15) DEFAULT NULL,
  `password` varchar(20) NOT NULL,
  `balance` decimal(10,0) NOT NULL,
  `isdeleted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_member
-- ----------------------------
INSERT INTO `t_member` VALUES ('242b9721-6222-4bcb-874e-7f8ec67cc80f', '李亚飞', '李亚飞2', '123', '12333', '123', '88', '0');
INSERT INTO `t_member` VALUES ('65da4577-825a-4aa3-bac7-1ff9a6aee7a3', 'ghhh', 'gggg', '610321344445', '56545612', '123', '0', '0');
INSERT INTO `t_member` VALUES ('ddis', 'lyf', '李亚飞', '839283', '13878676557', '123', '109', '0');

-- ----------------------------
-- Table structure for `t_monthcard`
-- ----------------------------
DROP TABLE IF EXISTS `t_monthcard`;
CREATE TABLE `t_monthcard` (
  `id` varchar(40) NOT NULL,
  `memberid` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `startdate` date NOT NULL,
  `enddate` date NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `operatorid` varchar(40) NOT NULL,
  `operatortime` datetime NOT NULL,
  `usebalance` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_monthcard
-- ----------------------------
INSERT INTO `t_monthcard` VALUES ('2b138008-c58b-472c-8ea9-169767417a94', '242b9721-6222-4bcb-874e-7f8ec67cc80f', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '2015-10-14', '2015-11-14', '0', '1', '2015-10-14 23:24:04', null);
INSERT INTO `t_monthcard` VALUES ('419aa51b-7416-446d-8f43-1eb4f33190c8', '242b9721-6222-4bcb-874e-7f8ec67cc80f', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '2015-10-14', '2015-11-14', '0', '1', '2015-10-14 23:21:19', '1');
INSERT INTO `t_monthcard` VALUES ('e9de393f-f576-4b16-8842-1d460325d1a8', '242b9721-6222-4bcb-874e-7f8ec67cc80f', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '2015-10-14', '2015-11-14', '0', '1', '2015-10-14 23:21:01', null);
INSERT INTO `t_monthcard` VALUES ('f65c680a-2d34-4bf1-b5ec-9893fce3d1d1', '242b9721-6222-4bcb-874e-7f8ec67cc80f', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '2015-10-14', '2015-11-14', '1', '1', '2015-10-14 23:25:19', '1');

-- ----------------------------
-- Table structure for `t_openlog`
-- ----------------------------
DROP TABLE IF EXISTS `t_openlog`;
CREATE TABLE `t_openlog` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `sentryboxid` varchar(40) NOT NULL,
  `ismanual` smallint(6) DEFAULT NULL,
  `opentype` smallint(6) DEFAULT NULL,
  `carno` varchar(40) NOT NULL,
  `operatorid` varchar(40) NOT NULL,
  `operatortime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_openlog
-- ----------------------------

-- ----------------------------
-- Table structure for `t_operator`
-- ----------------------------
DROP TABLE IF EXISTS `t_operator`;
CREATE TABLE `t_operator` (
  `id` varchar(40) NOT NULL,
  `loginname` varchar(40) NOT NULL,
  `realname` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` tinyint(4) NOT NULL,
  `isdeleted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_operator
-- ----------------------------
INSERT INTO `t_operator` VALUES ('1', 'admin', 'admin', 'admin', '1', null);
INSERT INTO `t_operator` VALUES ('6ddf7770-66a0-47e8-898f-c7ac9ebe99ef', 'd', 'd', '123', '4', '0');
INSERT INTO `t_operator` VALUES ('fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '001', '001', '001', '4', '0');

-- ----------------------------
-- Table structure for `t_parking`
-- ----------------------------
DROP TABLE IF EXISTS `t_parking`;
CREATE TABLE `t_parking` (
  `id` varchar(40) NOT NULL,
  `name` varchar(40) NOT NULL,
  `zone` varchar(40) DEFAULT NULL,
  `address` varchar(20) NOT NULL,
  `spacecount` int(11) DEFAULT NULL,
  `x` decimal(10,4) NOT NULL,
  `y` decimal(10,4) NOT NULL,
  `balance` decimal(12,2) NOT NULL,
  `operatorid` varchar(40) DEFAULT NULL,
  `createtime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_parking
-- ----------------------------
INSERT INTO `t_parking` VALUES ('14be8d9e-3506-421e-adb4-238c32df7bac', '测试2', '南部', '测试地址', '200', '34.3230', '23.3230', '0.00', '1', '2015-10-17 16:00:01');
INSERT INTO `t_parking` VALUES ('2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '测试停车场', '西部', '测试地址1dd', '300', '102.3230', '34.2303', '1101.00', null, null);
INSERT INTO `t_parking` VALUES ('3ea36501-4e29-4772-80af-110a9751fd48', 'csd', '东部', 'ew', '89', '34.0900', '108.2300', '0.00', '1', '2015-10-17 13:07:14');
INSERT INTO `t_parking` VALUES ('56f37043-21be-4f47-abfe-e5509d2ad8ed', 'ddd', '南部', '测试地址', '1000', '108.3200', '34.3200', '0.00', '1', '2015-10-19 20:18:40');

-- ----------------------------
-- Table structure for `t_parkingcar`
-- ----------------------------
DROP TABLE IF EXISTS `t_parkingcar`;
CREATE TABLE `t_parkingcar` (
  `id` varchar(40) NOT NULL COMMENT '停车记录id',
  `parkingid` varchar(40) NOT NULL,
  `memberid` varchar(40) DEFAULT NULL,
  `carno` varchar(20) NOT NULL,
  `entertime` datetime NOT NULL,
  `operatorid` varchar(40) DEFAULT NULL COMMENT '操作员',
  `sentryboxid` varchar(40) DEFAULT NULL COMMENT '岗亭id',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='停车记录表 对应当前停在停车场的车';

-- ----------------------------
-- Records of t_parkingcar
-- ----------------------------
INSERT INTO `t_parkingcar` VALUES ('29903580-e49a-4576-85a7-01a5ea884d18', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '', '京MMMMMM', '2015-10-26 20:47:00', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '0c885fb4-de36-4a30-a96a-ba1ef98a493a');
INSERT INTO `t_parkingcar` VALUES ('a0688a0e-cdcc-4f9e-8f8a-b947332f3e29', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '', '京MMMMMM', '2015-10-26 20:36:35', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '0c885fb4-de36-4a30-a96a-ba1ef98a493a');
INSERT INTO `t_parkingcar` VALUES ('d887a3a9-0117-4b3a-a8fb-bdf2742de8fc', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '', '京C39239', '2015-10-26 20:44:15', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '0c885fb4-de36-4a30-a96a-ba1ef98a493a');
INSERT INTO `t_parkingcar` VALUES ('f9b10b3f-d956-4e8b-ad50-6ff358c813c9', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '', '京MMMMMM', '2015-10-26 20:46:57', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '0c885fb4-de36-4a30-a96a-ba1ef98a493a');
INSERT INTO `t_parkingcar` VALUES ('sd', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', null, '陕A88888', '2015-10-08 20:21:20', '1', '0c885fb4-de36-4a30-a96a-ba1ef98a493a');

-- ----------------------------
-- Table structure for `t_parkingcarlog`
-- ----------------------------
DROP TABLE IF EXISTS `t_parkingcarlog`;
CREATE TABLE `t_parkingcarlog` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `carno` varchar(20) NOT NULL,
  `sentryboxid` varchar(40) DEFAULT NULL,
  `entertime` datetime DEFAULT NULL,
  `outtime` datetime NOT NULL,
  `memberid` varchar(40) DEFAULT NULL,
  `couponsid` varchar(40) DEFAULT NULL,
  `amount` decimal(10,0) NOT NULL,
  `operatorid` varchar(40) DEFAULT NULL,
  `operatortime` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_parkingcarlog
-- ----------------------------
INSERT INTO `t_parkingcarlog` VALUES ('070d0871-ac80-47db-9e17-81eb7137edf3', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-23 20:52:33', '2015-10-23 20:52:33', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-23 20:52:33');
INSERT INTO `t_parkingcarlog` VALUES ('1', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '2dq', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-01 22:20:16', '2015-09-29 22:20:22', '1', '1', '100', '1', '2015-10-08 22:20:35');
INSERT INTO `t_parkingcarlog` VALUES ('274f6481-92b3-410f-9816-3db7e9dc2aeb', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-22 23:25:45', '2015-10-22 23:25:47', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-22 23:25:47');
INSERT INTO `t_parkingcarlog` VALUES ('32b3988a-1b39-4a05-b39d-8720fd61d2e3', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-24 22:02:37', '2015-10-24 22:02:37', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-24 22:02:37');
INSERT INTO `t_parkingcarlog` VALUES ('46b417da-b925-4f62-8e69-519f774e4d15', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-23 20:52:22', '2015-10-23 20:52:24', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-23 20:52:24');
INSERT INTO `t_parkingcarlog` VALUES ('876f5be8-b227-4113-8d18-e844590ecea9', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-23 20:52:44', '2015-10-23 20:52:44', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-23 20:52:44');
INSERT INTO `t_parkingcarlog` VALUES ('aa9b1788-d652-46e5-a55d-1cc66995014f', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-22 23:25:42', '2015-10-23 20:52:29', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-23 20:52:29');
INSERT INTO `t_parkingcarlog` VALUES ('e76d239b-6c00-449a-b08a-a9fe20f1ca15', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '京MMMMMM', '0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2015-10-23 20:52:38', '2015-10-23 20:52:40', '', '', '1000', 'fd6269a5-d8dd-44d6-8be4-0c6ff2b68f34', '2015-10-23 20:52:40');

-- ----------------------------
-- Table structure for `t_rechargehistory`
-- ----------------------------
DROP TABLE IF EXISTS `t_rechargehistory`;
CREATE TABLE `t_rechargehistory` (
  `id` varchar(40) NOT NULL,
  `memberid` varchar(40) DEFAULT NULL,
  `operatorid` varchar(40) NOT NULL,
  `amount` decimal(12,2) NOT NULL,
  `rechargetime` datetime DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_rechargehistory
-- ----------------------------
INSERT INTO `t_rechargehistory` VALUES ('22470008-0790-4ae9-92be-cb6194305833', '242b9721-6222-4bcb-874e-7f8ec67cc80f', '1', '90.00', '2015-10-10 23:52:14', 'ddd');
INSERT INTO `t_rechargehistory` VALUES ('36ade447-38e6-4b3c-893c-d7a0bb64ad6b', 'ddis', '1', '9.00', '2015-10-10 23:52:03', '33');
INSERT INTO `t_rechargehistory` VALUES ('sds', 'ddis', '1', '100.00', '2015-10-08 23:07:35', '测试数据');

-- ----------------------------
-- Table structure for `t_reserved`
-- ----------------------------
DROP TABLE IF EXISTS `t_reserved`;
CREATE TABLE `t_reserved` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `mobile` varchar(20) NOT NULL,
  `memberid` varchar(40) NOT NULL,
  `carno` varchar(20) NOT NULL,
  `contacts` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_reserved
-- ----------------------------

-- ----------------------------
-- Table structure for `t_sentrybox`
-- ----------------------------
DROP TABLE IF EXISTS `t_sentrybox`;
CREATE TABLE `t_sentrybox` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `name` varchar(40) NOT NULL,
  `enterinfo` varchar(40) NOT NULL,
  `outinfo` varchar(40) DEFAULT NULL,
  `video1` varchar(40) DEFAULT NULL,
  `video2` varchar(40) DEFAULT NULL,
  `video3` varchar(40) DEFAULT NULL,
  `video4` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_sentrybox
-- ----------------------------
INSERT INTO `t_sentrybox` VALUES ('0c885fb4-de36-4a30-a96a-ba1ef98a493a', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '测试名称', '测试入口', '测试出口', '视频1', '视频2', '视频3', '视频4');
INSERT INTO `t_sentrybox` VALUES ('aca81d58-2689-4e2d-9e6e-3442e2849d97', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '测试刚听2', '测试入口', '测试出口', '视频1', '', '', '');

-- ----------------------------
-- Table structure for `t_settle`
-- ----------------------------
DROP TABLE IF EXISTS `t_settle`;
CREATE TABLE `t_settle` (
  `id` varchar(40) NOT NULL,
  `parkingid` varchar(40) NOT NULL,
  `operatorid` varchar(40) NOT NULL,
  `lasteditoperatorid` varchar(40) DEFAULT NULL,
  `verifyid` varchar(40) DEFAULT NULL,
  `amount` decimal(12,2) NOT NULL,
  `bankname` varchar(50) DEFAULT NULL,
  `accountowner` varchar(50) NOT NULL,
  `bankaccount` varchar(40) NOT NULL,
  `addtime` datetime NOT NULL,
  `verifytime` datetime DEFAULT NULL,
  `lastedittime` datetime DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL,
  `state` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_settle
-- ----------------------------
INSERT INTO `t_settle` VALUES ('109392c2-df9f-42c8-a1ad-2927d354f8e7', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '1', '1', null, '800.00', '中国银行', '3323', '393902030303', '2015-10-12 21:54:54', null, '2015-10-12 21:54:54', '23432', '0');
INSERT INTO `t_settle` VALUES ('53f6b4b5-3b27-4a11-9a7f-6b93479a7a9f', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '1', '1', '1', '1.00', '测试银行', '测试账户', '838292838', '2015-10-12 23:48:40', '2015-10-12 23:48:47', '2015-10-12 23:48:40', '测试哈哈', '1');
INSERT INTO `t_settle` VALUES ('b3ae4a02-626f-4d11-997a-e68ff92f3741', '2b9101a0-ba4e-41ce-9a51-f3681fb4e0cf', '1', '1', null, '900.00', '建设银行', 'idks', '29291329', '2015-10-12 21:48:33', null, '2015-10-12 21:48:33', 'remin', '0');

-- ----------------------------
-- Table structure for `t_transfer`
-- ----------------------------
DROP TABLE IF EXISTS `t_transfer`;
CREATE TABLE `t_transfer` (
  `id` varchar(40) NOT NULL,
  `settleid` varchar(40) NOT NULL,
  `transfertime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_transfer
-- ----------------------------
INSERT INTO `t_transfer` VALUES ('a4b887f5-4183-4529-8162-52eacc4cbd2d', '53f6b4b5-3b27-4a11-9a7f-6b93479a7a9f', '2015-10-12 23:48:47');

-- ----------------------------
-- View structure for `v_car`
-- ----------------------------
DROP VIEW IF EXISTS `v_car`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_car` AS select `c`.`id` AS `id`,`c`.`memberid` AS `memberid`,`c`.`trademark` AS `trademark`,`c`.`color` AS `color`,`c`.`typeid` AS `typeid`,`c`.`parkingtype` AS `parkingtype`,`c`.`carno` AS `carno`,`c`.`remarks` AS `remarks`,`t`.`typename` AS `typename`,`m`.`realname` AS `membername`,`m`.`mobile` AS `mobile` from ((`t_car` `c` left join `t_cartype` `t` on((`c`.`typeid` = `t`.`id`))) left join `t_member` `m` on((`c`.`memberid` = `m`.`id`))) ;

-- ----------------------------
-- View structure for `v_memberreport`
-- ----------------------------
DROP VIEW IF EXISTS `v_memberreport`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_memberreport` AS select '会员总数' AS `项目`,count(0) AS `数量` from `t_operator` union select '车辆总数' AS `项目`,count(0) AS `数量` from `t_car` union select '充值总金额' AS `项目`,sum(`t_rechargehistory`.`amount`) AS `数量` from `t_rechargehistory` ;

-- ----------------------------
-- View structure for `v_monthcard`
-- ----------------------------
DROP VIEW IF EXISTS `v_monthcard`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_monthcard` AS select `c`.`id` AS `id`,`c`.`memberid` AS `memberid`,`c`.`parkingid` AS `parkingid`,`c`.`startdate` AS `startdate`,`c`.`enddate` AS `enddate`,`c`.`amount` AS `amount`,`c`.`operatorid` AS `operatorid`,`c`.`operatortime` AS `operatortime`,`c`.`usebalance` AS `usebalance`,`m`.`realname` AS `membername`,`p`.`name` AS `parkingname`,`o`.`realname` AS `operatorname`,(case when (`c`.`usebalance` = 1) then '是' else '否' end) AS `isusebalance` from (((`t_monthcard` `c` left join `t_member` `m` on((`c`.`memberid` = `m`.`id`))) left join `t_parking` `p` on((`c`.`parkingid` = `p`.`id`))) left join `t_operator` `o` on((`c`.`operatorid` = `o`.`id`))) ;

-- ----------------------------
-- View structure for `v_parkingcar`
-- ----------------------------
DROP VIEW IF EXISTS `v_parkingcar`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_parkingcar` AS select `pc`.`id` AS `id`,`pc`.`parkingid` AS `parkingid`,`pc`.`memberid` AS `memberid`,`pc`.`carno` AS `carno`,`pc`.`entertime` AS `entertime`,`pc`.`operatorid` AS `operatorid`,`pc`.`sentryboxid` AS `sentryboxid`,`m`.`realname` AS `membername`,`m`.`mobile` AS `mobile`,`p`.`realname` AS `operatorname`,`c`.`trademark` AS `trademark`,`c`.`parkingtype` AS `parkingtype`,`c`.`color` AS `color`,`ct`.`typename` AS `typename` from ((((`t_parkingcar` `pc` left join `t_member` `m` on((`pc`.`memberid` = `m`.`id`))) left join `t_operator` `p` on((`pc`.`operatorid` = `p`.`id`))) left join `t_car` `c` on((`pc`.`carno` = `c`.`carno`))) left join `t_cartype` `ct` on((`c`.`typeid` = `ct`.`id`))) ;

-- ----------------------------
-- View structure for `v_parkingcarall`
-- ----------------------------
DROP VIEW IF EXISTS `v_parkingcarall`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_parkingcarall` AS select `p`.`parkingid` AS `parkingid`,`p`.`sentryboxid` AS `sentryboxid`,`p`.`carno` AS `carno`,`p`.`entertime` AS `entertime`,`pa`.`name` AS `parkingname`,`s`.`name` AS `sentryboxname` from ((`v_parkingcarall_temp` `p` left join `t_parking` `pa` on((`p`.`parkingid` = `pa`.`id`))) left join `t_sentrybox` `s` on((`p`.`sentryboxid` = `s`.`id`))) ;

-- ----------------------------
-- View structure for `v_parkingcarall_temp`
-- ----------------------------
DROP VIEW IF EXISTS `v_parkingcarall_temp`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_parkingcarall_temp` AS select `t_parkingcar`.`parkingid` AS `parkingid`,`t_parkingcar`.`sentryboxid` AS `sentryboxid`,`t_parkingcar`.`carno` AS `carno`,`t_parkingcar`.`entertime` AS `entertime` from `t_parkingcar` union select `t_parkingcarlog`.`parkingid` AS `parkingid`,`t_parkingcarlog`.`sentryboxid` AS `sentryboxid`,`t_parkingcarlog`.`carno` AS `carno`,`t_parkingcarlog`.`entertime` AS `entertime` from `t_parkingcarlog` ;

-- ----------------------------
-- View structure for `v_parkingcarlog`
-- ----------------------------
DROP VIEW IF EXISTS `v_parkingcarlog`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_parkingcarlog` AS select `p`.`id` AS `id`,`p`.`parkingid` AS `parkingid`,`p`.`carno` AS `carno`,`p`.`entertime` AS `entertime`,`p`.`outtime` AS `outtime`,`p`.`memberid` AS `memberid`,`p`.`couponsid` AS `couponsid`,`p`.`amount` AS `amount`,`p`.`operatorid` AS `operatorid`,`p`.`operatortime` AS `operatortime`,`pk`.`name` AS `parkingname`,`m`.`realname` AS `membername`,`c`.`id` AS `couponscode`,`o`.`realname` AS `operatorname` from ((((`t_parkingcarlog` `p` left join `t_parking` `pk` on((`p`.`parkingid` = `pk`.`id`))) left join `t_member` `m` on((`p`.`memberid` = `m`.`id`))) left join `t_coupons` `c` on((`p`.`couponsid` = `c`.`id`))) left join `t_operator` `o` on((`p`.`operatorid` = `o`.`id`))) ;

-- ----------------------------
-- View structure for `v_parkingcount`
-- ----------------------------
DROP VIEW IF EXISTS `v_parkingcount`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_parkingcount` AS select `t_parking`.`id` AS `parkingid`,'total' AS `title`,`t_parking`.`spacecount` AS `counts` from `t_parking` union select `t_reserved`.`parkingid` AS `parkingid`,'reserved' AS `title`,count(`t_reserved`.`parkingid`) AS `counts` from `t_reserved` group by `t_reserved`.`parkingid` union select `t_parkingcar`.`parkingid` AS `parkingid`,'parkinged' AS `title`,count(`t_parkingcar`.`parkingid`) AS `counts` from `t_parkingcar` group by `t_parkingcar`.`parkingid` ;

-- ----------------------------
-- View structure for `v_settle`
-- ----------------------------
DROP VIEW IF EXISTS `v_settle`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_settle` AS select `s`.`id` AS `id`,`s`.`parkingid` AS `parkingid`,`p`.`name` AS `parkingname`,`s`.`operatorid` AS `operatorid`,`o1`.`realname` AS `operatorname`,`s`.`lasteditoperatorid` AS `lasteditoperatorid`,`o2`.`realname` AS `lasteditoperatorname`,`s`.`verifyid` AS `verifyid`,`o3`.`realname` AS `verifyname`,`s`.`amount` AS `amount`,`s`.`bankname` AS `bankname`,`s`.`accountowner` AS `accountowner`,`s`.`bankaccount` AS `bankaccount`,`s`.`addtime` AS `addtime`,`s`.`verifytime` AS `verifytime`,`s`.`lastedittime` AS `lastedittime`,`s`.`remarks` AS `remarks`,`s`.`state` AS `state` from ((((`t_settle` `s` left join `t_parking` `p` on((`s`.`parkingid` = `p`.`id`))) left join `t_operator` `o1` on((`s`.`operatorid` = `o1`.`id`))) left join `t_operator` `o2` on((`s`.`lasteditoperatorid` = `o2`.`id`))) left join `t_operator` `o3` on((`s`.`verifyid` = `o3`.`id`))) ;
