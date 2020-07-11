/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./src/javascripts/main.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./src/javascripts/fadeInBackgroundRound.js":
/*!**************************************************!*\
  !*** ./src/javascripts/fadeInBackgroundRound.js ***!
  \**************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony default export */ __webpack_exports__[\"default\"] = ($(function() {\n    var nowScrollY;\n    var screenWidth = $(window).width();\n\n    $(window).scroll(function() {\n        nowScrollY = $(this).scrollTop();\n        if (screenWidth >= 1400) {\n            nowScrollY += 700;\n            setClass(nowScrollY);\n        }\n        else if (screenWidth <= 1399 && screenWidth >= 1024) {\n            nowScrollY += 200;\n            setClass(nowScrollY);\n        }\n        else if (screenWidth <= 1023 && screenWidth >= 768) {\n            nowScrollY += 100;\n            setClass(nowScrollY);\n        }\n        else if (screenWidth <= 767 && screenWidth >= 421) {\n            nowScrollY += 100;\n            setClass(nowScrollY);\n        }\n        else if (screenWidth <= 420) {\n            nowScrollY += 200;\n            setClass(nowScrollY);\n        }\n    })\n\n    function setClass(nowScrollY) {\n        var section01 = $('#about').offset().top;\n        var section02 = $('#member').offset().top;\n        var section03 = $('#blog').offset().top;\n\n        if (nowScrollY > section03) {\n            $('.ro-group03').addClass(\"appear-ro\");\n        }\n        else if (nowScrollY > section02) {\n            $('.ro-group02').addClass(\"appear-ro\");\n        }\n        else if (nowScrollY > section01) {\n            $('.ro-group01').addClass(\"appear-ro\");\n\n        }\n    }\n\n\n}));\n\n\n//# sourceURL=webpack:///./src/javascripts/fadeInBackgroundRound.js?");

/***/ }),

/***/ "./src/javascripts/hoverAnimation.js":
/*!*******************************************!*\
  !*** ./src/javascripts/hoverAnimation.js ***!
  \*******************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n /* harmony default export */ __webpack_exports__[\"default\"] = ($(\"#button\").hover(\n    function() {\n        $(this).addClass(\"button-hover\");\n    },\n    function() {\n        $(this).removeClass(\"button-hover\");\n    }\n));\n\n\n//# sourceURL=webpack:///./src/javascripts/hoverAnimation.js?");

/***/ }),

/***/ "./src/javascripts/main.js":
/*!*********************************!*\
  !*** ./src/javascripts/main.js ***!
  \*********************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony import */ var _stylesheets_style_css__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../stylesheets/style.css */ \"./src/stylesheets/style.css\");\n/* harmony import */ var _stylesheets_style_css__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_stylesheets_style_css__WEBPACK_IMPORTED_MODULE_0__);\n/* harmony import */ var _stylesheets_reset_css__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../stylesheets/reset.css */ \"./src/stylesheets/reset.css\");\n/* harmony import */ var _stylesheets_reset_css__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_stylesheets_reset_css__WEBPACK_IMPORTED_MODULE_1__);\n/* harmony import */ var _fadeInBackgroundRound_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./fadeInBackgroundRound.js */ \"./src/javascripts/fadeInBackgroundRound.js\");\n/* harmony import */ var _hoverAnimation_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./hoverAnimation.js */ \"./src/javascripts/hoverAnimation.js\");\n/* harmony import */ var _menu_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./menu.js */ \"./src/javascripts/menu.js\");\n/* harmony import */ var _smothScroll_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./smothScroll.js */ \"./src/javascripts/smothScroll.js\");\n\n\n\n\n\n\n\n\n\n\n\n\n//# sourceURL=webpack:///./src/javascripts/main.js?");

/***/ }),

/***/ "./src/javascripts/menu.js":
/*!*********************************!*\
  !*** ./src/javascripts/menu.js ***!
  \*********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony default export */ __webpack_exports__[\"default\"] = ($(function(){\n\nconst menu                = document.getElementById('menu');\nconst navigationContainer = document.getElementById('navigation-container');\nconst arrow               = document.getElementById('arrow');\nconst arrowIsOpened       = document.getElementById('arrow-is-opened');\nconst menuList            = document.getElementById('menu-list');\n\nmenu.addEventListener('click',function(){\n    menu.classList.toggle('menu-is-opened');\n    navigationContainer.classList.toggle('navigation-container-is-opened');\n    arrow.classList.toggle('dis-arrow');\n    arrowIsOpened.classList.toggle('dis-arrow');\n    menuList.classList.toggle('dis-menu-list');\n    })\n}\n));\n\n\n//# sourceURL=webpack:///./src/javascripts/menu.js?");

/***/ }),

/***/ "./src/javascripts/smothScroll.js":
/*!****************************************!*\
  !*** ./src/javascripts/smothScroll.js ***!
  \****************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony default export */ __webpack_exports__[\"default\"] = ($(function(){\n// #で始まるアンカーをクリックした場合に処理\n$('a[href^=\"#\"]').click(function() {\n// スクロールの速度\nvar speed = 400; // ミリ秒\n// アンカーの値取得\nvar href = $(this).attr(\"href\");\n// 移動先を取得\nvar target = $(href == \"#\" || href == \"\" ? 'html' : href);\n// 移動先を数値で取得\nvar position = target.offset().top - 75;\n// スムーススクロール\n$('body,html').animate({scrollTop:position}, speed, 'swing');\nreturn false;\n});\n}));\n\n\n//# sourceURL=webpack:///./src/javascripts/smothScroll.js?");

/***/ }),

/***/ "./src/stylesheets/reset.css":
/*!***********************************!*\
  !*** ./src/stylesheets/reset.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

eval("// extracted by mini-css-extract-plugin\n\n//# sourceURL=webpack:///./src/stylesheets/reset.css?");

/***/ }),

/***/ "./src/stylesheets/style.css":
/*!***********************************!*\
  !*** ./src/stylesheets/style.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

eval("// extracted by mini-css-extract-plugin\n\n//# sourceURL=webpack:///./src/stylesheets/style.css?");

/***/ })

/******/ });