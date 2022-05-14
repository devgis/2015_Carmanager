/*
Navicat MySQL Data Transfer

Source Server         : localmysql
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : db_carmanager

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-06 16:15:08
*/

SET FOREIGN_KEY_CHECKS=0;

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_log
-- ----------------------------
INSERT INTO `t_log` VALUES ('1', '2015-10-05 14:48:29', '6ddf7770-66a0-47e8-898f-c7ac9ebe99ef', '创建了系统');

-- ----------------------------
-- Table structure for `t_member`
-- ----------------------------
DROP TABLE IF EXISTS `t_member`;
CREATE TABLE `t_member` (
  `id` varchar(40) NOT NULL,
  `loginname` varchar(40) NOT NULL,
  `realname` varchar(20) NOT NULL,
  `idcard` varchar(20) DEFAULT NULL,
  `password` varchar(20) NOT NULL,
  `balance` decimal(10,0) NOT NULL,
  `isdeleted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_member
-- ----------------------------
INSERT INTO `t_member` VALUES ('242b9721-6222-4bcb-874e-7f8ec67cc80f', '李亚飞', '李亚飞2', '123', '123', '0', '0');
INSERT INTO `t_member` VALUES ('ddis', 'lyf', '李亚飞', '839283', '123', '100', '0');

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
INSERT INTO `t_operator` VALUES ('6ddf7770-66a0-47e8-898f-c7ac9ebe99ef', 'd', 'd', '123', '4', '0');
INSERT INTO `t_operator` VALUES ('dd', 'admin', 'admin', 'admin', '1', null);
