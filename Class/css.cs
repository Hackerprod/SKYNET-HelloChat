using System;
using System.IO;

namespace SkynetChat
{
    class css
    {
        private static string clase;

        public static void Save()
        {
            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SkynetChat", "css", "class.css"), GetMyCSS());
        }
        public static string GetMyCSS()
        {
            clase = @"

            /*Modifications of MainCSS:*/

            *, *:before, *:after {
            box-sizing: border-box;
            }

            .message {
            top:5px;                /*este no lo llevaba... lo puse con lo del avatar*/   
            color: black;
            padding: 8px 20px;
            line-height: 20px;
            border-radius: 7px;
            margin-bottom: 15px;
            position: relative;
            clear:both;
            max-width: 85%;

            }
            .message:before{
            bottom: 100%;
            top:-19px;              
            right:10px;
            border: solid transparent;
            content: ' ';
            height: 0;
            width: 0;
            position: absolute;
            pointer-events: none;
            border-bottom-color: #B6DEFF;
            border-width: 10px;
            }            
            .select-message {
            background-color:#eaf3fd !important;
            }
            .select-message:before{
            border-bottom-color: #eaf3fd !important;
            }
            .hide_message_arrow:before {
            display:none;
            }
            .my-message {
            background: #B6DEFF;
            float:right;
            }
            .other-message {
            background: #B9F98E;
            float:left;
            }
            .other-message:before {
            border-bottom-color: #B9F98E;
            left:unset;
            left:10px;
            }
            .message a{
            color:#0066cc;
            text-decoration:underline;
            cursor:hand;
            }
            a.mention-user{
            background-color:#689F38;
            text-decoration:none;
            color:white;
            padding:2px;
            border-radius:5px;
            }
            .message-data {
            clear:both;
            margin-bottom: 13px;
            margin-top: 2px;
            *margin-bottom: 5px;
            }            
            .privatemessage-data {
            color: DimGray;
            }
            .message-data-time {
            color: #a8aab1;
            padding-left: 6px;
            font-size: 8pt;
            }
            .buzz {
            color: #ff0000;
            }
            .align-right {
            text-align: right;
            }
            pre {
            margin: 0px;
            padding: 0px;
            font-size: 10pt;
            white-space: pre-wrap;
            word-wrap: break-word;
            *display:inline;
            }
            pre a {
            cursor: pointer;
            }


            /*---------------------------------------------*/
            /*Default*/
            .my-message-0 {
            background: #b6deff;
            float:right;
            }
            .my-message-0:before {
            border-bottom-color: #b6deff;
            }

            /*Verde*/
            .my-message-1 {
            background: #38f873;
            float:right;
            }
            .my-message-1:before {
            border-bottom-color: #38f873;
            }

            /*amarillo*/
            .my-message-2 {
            background: #ecfb47;
            color: #000000;
            float:right;
            }
            .my-message-2:before {
            border-bottom-color: #ecfb47;
            }

            /*morado*/
            .my-message-3 {
            background: #f93eb0;
            color: #ffffff;
            float:right;
            }
            .my-message-3:before {
            border-bottom-color: #f93eb0;
            }

            /*rosado*/
            .my-message-4 {
            background: #ff56fd;
            color: #ffffff;
            float:right;
            }
            .my-message-4:before {
            border-bottom-color: #ff56fd;
            }

            /*azul*/
            .my-message-5 {
            background: #0086ff;
            color: #ffffff;
            float:right;
            }
            .my-message-5:before {
            border-bottom-color: #0086ff;
            }

            /*naranja*/
            .my-message-6 {
            background: #ff8c00;
            color: #000000;
            float:right;
            }
            .my-message-6:before {
            border-bottom-color: #ff8c00;
            }

            /*rojo*/
            .my-message-7 {
            background: #ff0000;
            color: #ffffff;
            float:right;
            }
            .my-message-7:before {
            border-bottom-color: #ff0000;
            }

            /*gris*/
            .my-message-8 {
            background: #929191;
            color: #ffffff;
            float:right;
            }
            .my-message-8:before {
            border-bottom-color: #929191;
            }

            /*hackerprod*/
            .my-message-9 {
            background: #00c6ff;
            color: #FFFFFF;
            float:right;
            }
            .my-message-9:before {
            border-bottom-color: #00c6ff;
            }

            /*Smiley*/
            .my-message-Smiley {
            top:5px;                
            margin-bottom: 15px;
            float:right;
            }
            .my-message-Smiley:before {
            }
            /*---------------------------------------------*/

            /*---------------------------------------------*/

            /*Default*/
            .other-message-0 {
            background: #b6deff;
            float:left;
            }
            .other-message-0:before {
            border-bottom-color: #b6deff;
            left:unset;
            left:10px;
            }

            /*Verde*/
            .other-message-1 {
            background: #38f873;
            float:left;
            }
            .other-message-1:before {
            border-bottom-color: #38f873;
            left:unset;
            left:10px;
            }

            /*amarillo*/
            .other-message-2 {
            background: #ecfb47;
            color: #000000;
            float:left;
            }
            .other-message-2:before {
            border-bottom-color: #ecfb47;
            left:unset;
            left:10px;
            }

            /*morado*/
            .other-message-3 {
            background: #f93eb0;
            color: #ffffff;
            float:left;
            }
            .other-message-3:before {
            border-bottom-color: #f93eb0;
            left:unset;
            left:10px;
            }

            /*rosado*/
            .other-message-4 {
            background: #ff56fd;
            color: #ffffff;
            float:left;
            }
            .other-message-4:before {
            border-bottom-color: #ff56fd;
            left:unset;
            left:10px;
            }

            /*azul*/
            .other-message-5 {
            background: #0086ff;
            color: #ffffff;
            float:left;
            }
            .other-message-5:before {
            border-bottom-color: #0086ff;
            left:unset;
            left:10px;
            }

            /*naranja*/
            .other-message-6 {
            background: #ff8c00;
            color: #000000;
            float:left;
            }
            .other-message-6:before {
            border-bottom-color: #ff8c00;
            left:unset;
            left:10px;
            }

            /*rojo*/
            .other-message-7 {
            background: #ff0000;
            color: #ffffff;
            float:left;
            }
            .other-message-7:before {
            border-bottom-color: #ff0000;
            left:unset;
            left:10px;
            }

            /*gris*/
            .other-message-8 {
            background: #929191;
            color: #ffffff;
            float:left;
            }
            .other-message-8:before {
            border-bottom-color: #929191;
            left:unset;
            left:10px;
            }

            /*hackerprod*/
            .other-message-9 {
            background: #00c6ff;
            color: #FFFFFF;
            float:left;
            }
            .other-message-9:before {
            border-bottom-color: #00c6ff;
            left:unset;
            left:10px;
            }

            /*Smiley*/
            .other-message-Smiley {
            background: #ffffff;
            color: #000000;
            float:right;
            }
            .other-message-Smiley:before {
            border-bottom-color: #ffffff;
            }
            /*---------------------------------------------*/





            /*Default*/
            .0 {
            background: #b6deff;
            }
            .0:before {
            border-bottom-color: #b6deff;
            }

            /*Verde*/
            .1 {
            background: #38f873;
            }
            .1:before {
            border-bottom-color: #38f873;
            }

            /*amarillo*/
            .2 {
            background: #ecfb47;
            color: #000000;
            }
            .2:before {
            border-bottom-color: #ecfb47;
            }

            /*morado*/
            .3 {
            background: #f93eb0;
            color: #ffffff;
            }
            .3:before {
            border-bottom-color: #f93eb0;
            }

            /*rosado*/
            .4 {
            background: #ff56fd;
            color: #ffffff;
            }
            .4:before {
            border-bottom-color: #ff56fd;
            }

            /*azul*/
            .5 {
            background: #0086ff;
            color: #ffffff;
            }
            .5:before {
            border-bottom-color: #0086ff;
            }

            /*naranja*/
            .6 {
            background: #ff8c00;
            color: #000000;
            }
            .6:before {
            border-bottom-color: #ff8c00;
            }

            /*rojo*/
            .7 {
            background: #ff0000;
            color: #ffffff;
            }
            .7:before {
            border-bottom-color: #ff0000;
            }

            /*gris*/
            .8 {
            background: #929191;
            color: #ffffff;
            }
            .8:before {
            border-bottom-color: #929191;
            }

            /*hackerprod*/
            .9 {
            background: #00c6ff;
            color: #000000;
            }
            .9:before {
            border-bottom-color: #00c6ff;
            }
            /*---------------------------------------------*/
            .my-user-avatar {
	            float: right;
	            height: 28px;
	            margin-right: 8px;
	            margin-top: -4px;
	            overflow: hidden;
	            width: 28px;
            }
            .other-user-avatar {
	            float: left;
	            height: 28px;
	            margin-right: 8px;
	            margin-top: -4px;
	            overflow: hidden;
	            width: 35px;
            }





           




           





            ";
            return clase;
        }
        public static string GetHTMLCSS()
        {
            clase = @"

            .navbar-fixed-top,.navbar-fixed-bottom{position:fixed;right:0;left:0;z-index:1030}@media (min-width:768px){.navbar-fixed-top,.navbar-fixed-bottom{border-radius:0}}
            .navbar-fixed-top{top:0;border-width:0 0 1px}.navbar-fixed-bottom{bottom:0;margin-bottom:0;border-width:1px 0 0}
            .navbar-brand:hover,.navbar-brand:focus{text-decoration:none}@media (min-width:768px){.navbar>.container .navbar-brand,.navbar>.container-fluid .navbar-brand{margin-left:-15px}}
            .navbar-form.navbar-right:last-child{margin-right:-15px}}.navbar-nav>li>.dropdown-menu{margin-top:0;border-top-right-radius:0;border-top-left-radius:0}.navbar-fixed-bottom .navbar-nav>li>.dropdown-menu{border-bottom-right-radius:0;border-bottom-left-radius:0}
            .panel{margin-bottom:20px;background-color:#fff;border:1px solid transparent;border-radius:4px;-webkit-box-shadow:0 1px 1px rgba(0,0,0,.05);box-shadow:0 1px 1px rgba(0,0,0,.05)}.panel-body{padding:15px}.panel-heading{padding:10px 15px;border-bottom:1px solid transparent;border-top-right-radius:3px;border-top-left-radius:3px}.panel-heading>.dropdown .dropdown-toggle{color:inherit}.panel-title{margin-top:0;margin-bottom:0;font-size:16px;color:inherit}.panel-title>a{color:inherit}.panel-footer{padding:10px 15px;background-color:#f5f5f5;border-top:1px solid #ddd;border-bottom-right-radius:3px;border-bottom-left-radius:3px}.panel>.list-group{margin-bottom:0}.panel>.list-group .list-group-item{border-width:1px 0;border-radius:0}.panel>.list-group:first-child .list-group-item:first-child{border-top:0;border-top-right-radius:3px;border-top-left-radius:3px}.panel>.list-group:last-child .list-group-item:last-child{border-bottom:0;border-bottom-right-radius:3px;border-bottom-left-radius:3px}.panel-heading+.list-group .list-group-item:first-child{border-top-width:0}.panel>.table,.panel>.table-responsive>.table{margin-bottom:0}.panel>.table:first-child,.panel>.table-responsive:first-child>.table:first-child{border-top-right-radius:3px;border-top-left-radius:3px}.panel>.table:first-child>thead:first-child>tr:first-child td:first-child,.panel>
            .panel-group .panel-footer+.panel-collapse .panel-body{border-bottom:1px solid #ddd}.panel-default{border-color:#ddd}.panel-default>
            .panel-heading{color:#333;background-color:#f5f5f5;border-color:#ddd}.panel-default>.panel-heading+.panel-collapse .panel-body{border-top-color:#ddd}


            /* header */
            .header {
	            margin: 0;
	            padding: 0;
	            border: 0;
	            margin-bottom: 0;
	            background: #318ce7;
            }
            .header .my-user-photo {
	            float: left;
	            height: 28px;
	            margin-right: 8px;
	            margin-top: -4px;
	            overflow: hidden;
	            width: 28px;
            }
            .header .caret {
	            margin-left: 5px;
            }
            .header-fixed {
	            padding-top: 44px;
            }
            .header.navbar {
	            border-radius: 0;
	            box-shadow: none;
	            min-height: 44px;
            }
            .header h3, .header h4 {
	            margin: 0;
	            padding: 0;
            }
            .header .navbar-toggle {
	            border: 0;
            }
            .header .header-nav {
	            float: right;
            }
            .header .header-nav .icon-nav {
	            float: right;
            }
            .header .header-nav .icon-nav > li {
	            float: left;
            }
            .header .header-nav .icon-nav > li > a {
	            padding: 12px;
            }
            .header .header-nav .icon-nav > li > a > i {
	            font-size: 20px;
            }
            .header .header-nav .icon-nav > li > a > .badge {
	            background: none repeat scroll 0 0 #FF0000;
	            border: 0 none;
	            border-radius: 100%;
	            box-shadow: none;
	            position: absolute;
	            right: 0;
	            top: 7px;
            }
            .header .header-nav .icon-nav > li > .dropdown-menu {
	            margin-top: 0;
            }
            .header .navbar-header {
	            float: none !important;
            }
            .header .navbar-brand {
	            height: 44px;
	            padding-top: 0px;
	            padding-bottom: 0px;
	            color: #f5f5f5;
            }
            .header .navbar-brand .logo {
	            background-image: url('../img/om_48.ico');
	            background-repeat: no-repeat;
	            background-size: 36px 36px;
	            float: left;
	            height: 36px;
	            margin-top: 5px;
	            width: 36px;
            }
            .header .navbar-brand .name {
	            float: left;
	            margin: 10px 0 0 10px;
            }
            .header .navbar-toggle.page-sidebar-toggle {
	            display: none;
            }
            .header .settings .dropdown-menu {
	            width: 300px;
            }
            .header .header-nav .icon-nav > li > a {
	            color: #f5f5f5;
            }
            .header .header-nav .icon-nav > li > a:hover, .header .header-nav .icon-nav > li > a:focus, .header .header-nav .nav .open > a, .header .header-nav .nav .open > a:hover, .header .header-nav .nav .open > a:focus, .header .navbar-toggle.page-sidebar-toggle:hover, .header .navbar-toggle.page-sidebar-toggle:focus {
	            background: #084C9F !important;
	            color: #fff !important;
            }
            .page-fluid .header .container {
	            width: auto;
            }
            .header .navbar-toggle.sidebar-toggle, .header .navbar-toggle.mobile-menu {
	            display: block;
	            border: 0 none;
	            border-radius: 0;
	            margin: 0;
	            padding: 15px 10px;
            }
            .header .user-detail-menu {
	            padding: 10px;
	            width: 250px;
            }

            ";
            return clase;
        }

    }
}
