/* 
 *  Copyright (c) 2012-2013, Inspirock Corporation.
 *  All rights reserved.
 */

require(["modules/analytics","modules/analyticsEventParams","modules/utils","modules/header","jquery"],function(b,c,d,e){var a={initialize:function(){b.setPageType("Error Page");b.trackPageView();var a=d.getParameterByName("code");b.trackNonInteractionEvent(c.ERROR,c.ACT_CODE,a);e.initialize()}};a.initialize();return a});define("error",function(){});