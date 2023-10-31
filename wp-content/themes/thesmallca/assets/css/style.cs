@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-Regular.woff2") format("woff2"), url("../fonts/NeueMontreal-Regular.woff") format("woff");
  font-weight: normal;
  font-style: normal;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-Italic.woff2") format("woff2"), url("../fonts/NeueMontreal-Italic.woff") format("woff");
  font-weight: normal;
  font-style: italic;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-BoldItalic.woff2") format("woff2"), url("../fonts/NeueMontreal-BoldItalic.woff") format("woff");
  font-weight: bold;
  font-style: italic;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-Bold.woff2") format("woff2"), url("../fonts/NeueMontreal-Bold.woff") format("woff");
  font-weight: bold;
  font-style: normal;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-Light.woff2") format("woff2"), url("../fonts/NeueMontreal-Light.woff") format("woff");
  font-weight: 300;
  font-style: normal;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-MediumItalic.woff2") format("woff2"), url("../fonts/NeueMontreal-MediumItalic.woff") format("woff");
  font-weight: 500;
  font-style: italic;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-Medium.woff2") format("woff2"), url("../fonts/NeueMontreal-Medium.woff") format("woff");
  font-weight: 500;
  font-style: normal;
  font-display: swap;
}
@font-face {
  font-family: "Neue_Montreal";
  src: url("../fonts/NeueMontreal-LightItalic.woff2") format("woff2"), url("../fonts/NeueMontreal-LightItalic.woff") format("woff");
  font-weight: 300;
  font-style: italic;
  font-display: swap;
}
/*======================================== config =================================*/
*,
*:before,
*:after {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

a {
  text-decoration: none;
  color: #000000;
  transition: 0.3s all !important;
}
a:hover {
  color: red;
}

a:hover,
a:focus {
  text-decoration: none;
}

input {
  -webkit-transition: all 0.3s ease-in-out 0s;
  transition: all 0.3s ease-in-out 0s;
}

html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  outline: none !important;
}

body {
  max-width: 100%;
  width: 100%;
  background: #F2F2F2;
  font-size: 18px;
  line-height: 1.3;
  font-family: "Neue_Montreal";
  font-weight: normal;
  color: #181818;
}
body.active {
  overflow: hidden;
}
@media (max-width: 1600px) {
  body {
    font-size: 16px;
  }
}
@media (max-width: 1023px) {
  body {
    font-size: 14px;
  }
}
body::-webkit-scrollbar-track {
  background-color: #000000;
}
body::-webkit-scrollbar {
  width: 4px;
  background-color: #000000;
}
body::-webkit-scrollbar-thumb {
  background-color: #FFFCE1;
}
body img {
  max-width: 100%;
}

.gsap-marker-end, .gsap-marker-start, .gsap-marker-scroller-end, .gsap-marker-scroller-start {
  display: none !important;
}

/*======================================== end config =================================*/
.container {
  max-width: 1232px;
  padding: 0 16px;
  margin: 0 auto;
}
@media (max-width: 1600px) {
  .container {
    max-width: 100%;
    padding: 0 100px;
  }
}
@media (max-width: 1400px) {
  .container {
    padding: 0 60px;
  }
}
@media (max-width: 1023px) {
  .container {
    padding: 0 40px;
  }
}
@media (max-width: 767px) {
  .container {
    padding: 0 20px;
  }
}

.avarta {
  display: flex;
  align-items: center;
  justify-content: center;
}

.row {
  display: flex;
  margin: 0 -16px;
  flex-wrap: wrap;
}
@media (max-width: 1023px) {
  .row {
    margin: 0 -10px;
  }
}
.row > div {
  padding: 0 16px;
}
@media (max-width: 1023px) {
  .row > div {
    padding: 0 10px;
  }
}

.w-100 {
  width: 100%;
}

.col-md-3 {
  max-width: 33.3333333333%;
  flex: 0 0 33.3333333333%;
}

.col-md-9 {
  max-width: 66.6666666667%;
  flex: 0 0 66.6666666667%;
}

.text-center {
  text-align: center;
}

.d-none {
  display: none !important;
}

.title {
  margin-bottom: 90px;
}
@media (max-width: 1600px) {
  .title {
    margin-bottom: 60px;
  }
}
@media (max-width: 1023px) {
  .title {
    margin-bottom: 48px;
  }
}
@media (max-width: 767px) {
  .title {
    margin-bottom: 24px;
  }
}
.title h2 {
  font-size: 100px;
  line-height: 1;
  font-weight: bold;
  position: relative;
  display: inline-flex;
  align-items: center;
}
@media (max-width: 1600px) {
  .title h2 {
    font-size: 80px;
  }
}
@media (max-width: 1400px) {
  .title h2 {
    font-size: 60px;
  }
}
@media (max-width: 1023px) {
  .title h2 {
    font-size: 48px;
  }
}
@media (max-width: 767px) {
  .title h2 {
    font-size: 36px;
  }
}
.title h2 span {
  font-size: 48px;
  font-weight: 500;
  padding-left: 20px;
}
@media (max-width: 1400px) {
  .title h2 span {
    font-size: 30px;
  }
}
@media (max-width: 1023px) {
  .title h2 span {
    font-size: 24px;
  }
}
@media (max-width: 767px) {
  .title h2 span {
    font-size: 16px;
    padding-left: 12px;
  }
}

.header-main {
  font-weight: 500;
  padding: 20px 0;
  z-index: 10;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  background: #F2F2F2;
}
@media (max-width: 1023px) {
  .header-main {
    padding: 12px 0;
  }
}
@media (max-width: 767px) {
  .header-main {
    padding: 8px 0;
  }
}
.header-main .container {
  max-width: 1440px;
}

.content-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.content-header .btn-menu a {
  border-bottom: 1px solid;
  display: inline-flex;
  line-height: 1;
}
.content-header .logo {
  display: flex;
  align-items: center;
  justify-content: center;
}
.content-header .logo a {
  display: inline-flex;
  align-items: center;
  justify-content: center;
}

.nav-menu {
  position: fixed;
  top: 0;
  right: -100%;
  width: 100%;
  height: 100%;
  z-index: 10;
  background: #181818;
  padding: 20px 0 80px 0;
  transition: 0.6s all !important;
}
@media (max-width: 1400px) {
  .nav-menu {
    padding: 20px 0;
  }
}
.nav-menu.open_menu {
  right: 0;
}
.nav-menu .container {
  height: 100%;
  max-width: 1440px;
}
.nav-menu ul {
  list-style: none;
}
.nav-menu .content-nav {
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
.nav-menu .h-menu ul li {
  margin-bottom: 40px;
}
@media (max-width: 1023px) {
  .nav-menu .h-menu ul li {
    margin-bottom: 32px;
  }
}
@media (max-width: 767px) {
  .nav-menu .h-menu ul li {
    margin-bottom: 16px;
  }
}
.nav-menu .h-menu ul li:last-child {
  margin-bottom: 0;
}
.nav-menu .h-menu ul li a {
  color: #FFFCE1;
  font-size: 86px;
  font-weight: bold;
  text-transform: uppercase;
}
@media (max-width: 1400px) {
  .nav-menu .h-menu ul li a {
    font-size: 60px;
  }
}
@media (max-width: 1023px) {
  .nav-menu .h-menu ul li a {
    font-size: 48px;
  }
}
@media (max-width: 767px) {
  .nav-menu .h-menu ul li a {
    font-size: 30px;
  }
}
.nav-menu .social ul {
  display: flex;
}
.nav-menu .social ul li {
  margin-right: 24px;
}
.nav-menu .social ul li:last-child {
  margin-right: 0;
}
@media (max-width: 767px) {
  .nav-menu .social ul li img {
    width: 40px;
  }
}
.nav-menu .btn-menu a {
  color: #FFFCE1;
}

footer {
  background: #181818;
  padding: 100px 0;
  color: #FFFCE1;
  line-height: 1.5;
  font-size: 20px;
}
@media (max-width: 1600px) {
  footer {
    font-size: 18px;
  }
}
@media (max-width: 1400px) {
  footer {
    font-size: 16px;
    padding: 80px 0;
  }
}
@media (max-width: 1023px) {
  footer {
    padding: 40px 0;
  }
}
@media (max-width: 767px) {
  footer {
    padding: 24px 0;
    font-size: 14px;
  }
}
footer .container {
  max-width: 1440px;
}
@media (max-width: 1600px) {
  footer .container {
    max-width: 100%;
  }
}

.footer-center {
  padding: 40px 0;
  border-top: 1px solid rgba(255, 252, 225, 0.08);
  border-bottom: 1px solid rgba(255, 252, 225, 0.08);
  margin: 40px 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
}
@media (max-width: 1400px) {
  .footer-center {
    padding: 30px 0;
    margin: 30px 0;
  }
}
@media (max-width: 1023px) {
  .footer-center {
    padding: 24px 0;
    margin: 24px 0;
    display: block;
  }
}
@media (max-width: 767px) {
  .footer-center {
    padding: 12px 0;
    margin: 12px 0;
    display: block;
  }
}
.footer-center ul {
  list-style: none;
  display: flex;
  align-items: center;
  justify-content: center;
}
.footer-center .get-touch {
  display: flex;
  align-items: center;
}
@media (max-width: 1023px) {
  .footer-center .get-touch {
    display: none;
  }
}
.footer-center .get-touch h2 {
  font-size: 80px;
  font-weight: bold;
  color: #DAF38A;
  text-transform: uppercase;
}
@media (max-width: 1600px) {
  .footer-center .get-touch h2 {
    font-size: 60px;
  }
}
@media (max-width: 1400px) {
  .footer-center .get-touch h2 {
    font-size: 48px;
  }
}
.footer-center .get-touch a {
  font-size: 40px;
  font-weight: 500;
  color: #FFFCE1;
  margin-left: 10px;
  position: relative;
  top: 14px;
}
@media (max-width: 1600px) {
  .footer-center .get-touch a {
    font-size: 32px;
    top: 8px;
  }
}
@media (max-width: 1400px) {
  .footer-center .get-touch a {
    font-size: 24px;
    top: 8px;
  }
}

.footer-top .row {
  justify-content: space-between;
  align-items: center;
}
.footer-top ul {
  list-style: none;
  display: flex;
}
@media (max-width: 1023px) {
  .footer-top ul {
    justify-content: space-between;
  }
}
@media (max-width: 767px) {
  .footer-top ul {
    margin: 0 -10px;
    flex-wrap: wrap;
  }
}
.footer-top ul li {
  margin-right: 49px;
}
@media (max-width: 1023px) {
  .footer-top ul li {
    margin-right: 40px;
  }
}
@media (max-width: 767px) {
  .footer-top ul li {
    margin: 0;
    padding: 0 10px;
    flex: 0 0 50%;
    max-width: 50%;
  }
}
@media (max-width: 767px) {
  .footer-top ul li:first-child {
    flex: 0 0 100%;
    max-width: 100%;
    margin-bottom: 12px;
  }
}
.footer-top ul li:last-child {
  margin-right: 0;
}
.footer-top ul li label {
  font-weight: 500;
  opacity: 0.5;
  margin-bottom: 12px;
  display: block;
}
@media (max-width: 767px) {
  .footer-top ul li label {
    margin-bottom: 6px;
  }
}
@media (max-width: 1023px) {
  .footer-top .col-md-5 {
    display: none;
  }
}
@media (max-width: 1023px) {
  .footer-top .col-md-7 {
    max-width: 100%;
    flex: 0 0 100%;
  }
}

@media (max-width: 767px) {
  .footer-bottom {
    font-size: 12px;
    text-align: justify;
  }
}

main {
  padding-top: 96px;
}
@media (max-width: 1023px) {
  main {
    padding-top: 76px;
  }
}
@media (max-width: 767px) {
  main {
    padding-top: 64px;
  }
}

.box-featured {
  padding: 194px 0;
}
@media (max-width: 1600px) {
  .box-featured {
    padding: 100px 0;
  }
}
@media (max-width: 767px) {
  .box-featured {
    padding: 32px 0;
  }
}
.box-featured .container {
  max-width: 1300px;
}

.content-featured .col-md-6 {
  max-width: 50%;
  flex: 0 0 50%;
  padding: 0 15px;
}
@media (max-width: 767px) {
  .content-featured .col-md-6 {
    max-width: 100%;
    flex: 0 0 100%;
    padding: 0 10px;
  }
}

.list-feat {
  max-width: 566px;
  margin-left: auto;
}
@media (max-width: 767px) {
  .list-feat {
    max-width: 100%;
    margin: 0;
  }
}

.item-feat {
  margin-bottom: 70px;
  font-size: 20px;
}
@media (max-width: 1600px) {
  .item-feat {
    font-size: 18px;
    margin-bottom: 50px;
  }
}
@media (max-width: 1023px) {
  .item-feat {
    font-size: 14px;
    margin-bottom: 40px;
  }
}
@media (max-width: 1023px) {
  .item-feat {
    font-size: 12px;
    margin-bottom: 32px;
  }
}
.item-feat:last-child {
  margin-bottom: 0;
}
.item-feat .avarta {
  margin-bottom: 16px;
}
@media (max-width: 767px) {
  .item-feat .avarta {
    margin-bottom: 10px;
  }
}
.item-feat h3 {
  font-size: 28px;
  font-weight: bold;
  flex: 0 0 60%;
  padding-right: 14px;
}
@media (max-width: 1600px) {
  .item-feat h3 {
    font-size: 22px;
  }
}
@media (max-width: 1400px) {
  .item-feat h3 {
    font-size: 20px;
  }
}
@media (max-width: 1023px) {
  .item-feat h3 {
    font-size: 16px;
  }
}
@media (max-width: 767px) {
  .item-feat h3 {
    font-size: 14px;
  }
}
.item-feat .desc-head {
  display: flex;
  justify-content: space-between;
}
.item-feat .desc-head .desc {
  text-align: right;
  flex: 0 0 40%;
}

.sidebar-feat {
  position: sticky;
  top: 100px;
}
@media (max-width: 767px) {
  .sidebar-feat {
    top: 0;
    position: relative;
    margin-bottom: 24px;
  }
}
.sidebar-feat .title-feat {
  margin-bottom: 36px;
}
@media (max-width: 767px) {
  .sidebar-feat .title-feat {
    margin-bottom: 0;
  }
}
.sidebar-feat .title-feat h2 {
  font-size: 100px;
  font-weight: bold;
  line-height: 1;
  position: relative;
}
@media (max-width: 1600px) {
  .sidebar-feat .title-feat h2 {
    font-size: 80px;
  }
}
@media (max-width: 1400px) {
  .sidebar-feat .title-feat h2 {
    font-size: 60px;
  }
}
@media (max-width: 1023px) {
  .sidebar-feat .title-feat h2 {
    font-size: 48px;
  }
}
@media (max-width: 767px) {
  .sidebar-feat .title-feat h2 {
    font-size: 36px;
  }
}
.sidebar-feat .title-feat h2 span {
  position: absolute;
  font-size: 20px;
  font-weight: 500;
  max-width: 280px;
  line-height: 1.3;
  left: 30%;
  top: 32px;
}
@media (max-width: 1600px) {
  .sidebar-feat .title-feat h2 span {
    left: 26%;
    top: 18px;
    font-size: 18px;
  }
}
@media (max-width: 1400px) {
  .sidebar-feat .title-feat h2 span {
    font-size: 16px;
    left: 18%;
    top: 10px;
  }
}
@media (max-width: 1023px) {
  .sidebar-feat .title-feat h2 span {
    font-size: 14px;
    left: 18%;
    top: 5px;
  }
}
@media (max-width: 767px) {
  .sidebar-feat .title-feat h2 span {
    left: 20%;
    font-size: 11px;
    top: 4px;
    line-height: normal;
  }
}
@media (max-width: 767px) {
  .sidebar-feat .view-all {
    position: absolute;
    bottom: 5px;
    right: 0;
    z-index: 2;
  }
}

.view-all a {
  display: inline-flex;
  align-items: center;
  font-size: 20px;
}
@media (max-width: 1023px) {
  .view-all a {
    font-size: 16px;
  }
}
@media (max-width: 767px) {
  .view-all a {
    font-size: 14px;
    font-weight: 500;
  }
}
.view-all a span {
  border-bottom: 1px solid;
}
.view-all a svg {
  margin-left: 16px;
}
@media (max-width: 1023px) {
  .view-all a svg {
    width: auto;
    height: 20px;
    margin-left: 10px;
  }
}
@media (max-width: 767px) {
  .view-all a svg {
    height: 18px;
    margin-left: 8px;
  }
}

.list-article .col-md-4 {
  flex: 0 0 33.3333333333%;
  max-width: 33.3333333333%;
}
@media (max-width: 767px) {
  .list-article .col-md-4 {
    max-width: 100%;
    flex: 0 0 100%;
    margin-bottom: 0;
    margin-top: 20px;
  }
  .list-article .col-md-4:last-child {
    margin-bottom: 0;
  }
}
.list-article .view-all {
  margin-top: 65px;
  text-align: center;
}
@media (max-width: 1023px) {
  .list-article .view-all {
    margin-top: 40px;
  }
}
@media (max-width: 767px) {
  .list-article .view-all {
    margin-top: 24px;
  }
}

@media (max-width: 767px) {
  .item-article {
    display: flex;
  }
}
.item-article .avarta {
  margin-bottom: 24px;
  position: relative;
  overflow: hidden;
  padding-top: 64.9595687332%;
}
@media (max-width: 767px) {
  .item-article .avarta {
    margin-bottom: 0;
    padding: 0;
    flex: 0 0 45%;
    margin-right: 10px;
  }
  .item-article .avarta a {
    display: flex;
    align-items: center;
    justify-content: center;
  }
}
.item-article .avarta img {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  object-fit: cover;
}
@media (max-width: 767px) {
  .item-article .avarta img {
    position: relative;
  }
}
.item-article .date {
  color: #181818;
  opacity: 0.5;
}
@media (max-width: 767px) {
  .item-article .date {
    font-size: 12px;
  }
}
.item-article h3 a {
  display: block;
  margin: 12px 0;
  font-size: 24px;
  font-weight: bold;
  text-transform: uppercase;
  text-overflow: ellipsis;
  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
}
@media (max-width: 1600px) {
  .item-article h3 a {
    font-size: 22px;
  }
}
@media (max-width: 1400px) {
  .item-article h3 a {
    font-size: 20px;
  }
}
@media (max-width: 1023px) {
  .item-article h3 a {
    font-size: 16px;
  }
}
@media (max-width: 767px) {
  .item-article h3 a {
    font-size: 14px;
    margin: 10px 0 0 0;
  }
}
.item-article .desc {
  opacity: 0.65;
  color: #181818;
  text-overflow: ellipsis;
  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 3;
  -webkit-box-orient: vertical;
}
@media (max-width: 767px) {
  .item-article .desc {
    display: none;
  }
}

.box-article {
  padding: 0 0 114px 0;
}
@media (max-width: 1600px) {
  .box-article {
    padding: 0 0 100px 0;
  }
}
@media (max-width: 767px) {
  .box-article {
    padding: 24px 0 48px 0;
  }
}
@media (max-width: 767px) {
  .box-article .list-article .col-md-4 {
    max-width: 100%;
    flex: 0 0 100%;
    margin-bottom: 0;
    margin-top: 20px;
  }
  .box-article .list-article .col-md-4:last-child {
    margin-bottom: 0;
  }
}

.box-exhibiton {
  padding: 95px 0;
}
@media (max-width: 1023px) {
  .box-exhibiton {
    padding: 48px 0;
  }
}
@media (max-width: 767px) {
  .box-exhibiton {
    padding: 24px 0 48px 0;
  }
}
.box-exhibiton .container {
  max-width: 1440px;
}

.content-exhibition {
  display: flex;
  justify-content: space-between;
}
@media (max-width: 767px) {
  .content-exhibition {
    flex-wrap: wrap;
  }
}
.content-exhibition .ex-left {
  max-width: 522px;
  flex: 0 0 522px;
}
@media (max-width: 1400px) {
  .content-exhibition .ex-left {
    max-width: 400px;
    flex: 0 0 400px;
  }
}
@media (max-width: 1023px) {
  .content-exhibition .ex-left {
    max-width: 250px;
    flex: 0 0 250px;
  }
}
@media (max-width: 767px) {
  .content-exhibition .ex-left {
    padding: 0;
    max-width: 100%;
    flex: 0 0 100%;
  }
}
.content-exhibition .ex-right {
  flex: 0 0 calc(100% - 522px);
  max-width: calc(100% - 522px);
  padding-left: 162px;
}
@media (max-width: 1400px) {
  .content-exhibition .ex-right {
    flex: 0 0 calc(100% - 400px);
    max-width: calc(100% - 400px);
    padding-left: 48px;
  }
}
@media (max-width: 1023px) {
  .content-exhibition .ex-right {
    flex: 0 0 calc(100% - 250px);
    max-width: calc(100% - 250px);
    padding-left: 40px;
  }
}
@media (max-width: 767px) {
  .content-exhibition .ex-right {
    padding: 0;
    max-width: 100%;
    flex: 0 0 100%;
  }
}

.item-exh {
  padding: 30px 0;
  border-bottom: 1px solid rgba(24, 24, 24, 0.15);
}
@media (max-width: 1023px) {
  .item-exh {
    padding: 20px 0;
  }
}
.item-exh .head-ard {
  display: flex;
  justify-content: space-between;
  position: relative;
  padding-right: 40px;
  cursor: pointer;
}
@media (max-width: 1023px) {
  .item-exh .head-ard {
    display: block;
  }
}
.item-exh .head-ard .icon {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  top: 0;
  right: 0;
  transition: 0.3s all !important;
}
.item-exh .head-ard.active {
  pointer-events: none;
}
.item-exh .head-ard.active .icon {
  transform: rotate(180deg);
}
.item-exh .answer {
  padding-top: 20px;
  line-height: 1.4;
  display: none;
}
@media (max-width: 767px) {
  .item-exh .answer {
    padding-top: 14px;
  }
}

.sidebar-ex {
  position: sticky;
  top: 100px;
}
@media (max-width: 767px) {
  .sidebar-ex {
    top: 0;
    position: relative;
  }
}
.sidebar-ex .avarta {
  display: none;
}
@media (max-width: 767px) {
  .sidebar-ex .avarta {
    position: absolute;
    opacity: 0;
    z-index: -1;
  }
}
.sidebar-ex .avarta img {
  width: 100%;
}
.sidebar-ex .avarta.active {
  display: block;
}
.sidebar-ex h2 {
  font-size: 80px;
  font-weight: bold;
  position: relative;
  line-height: 1.1;
  margin-bottom: 70px;
}
@media (max-width: 1600px) {
  .sidebar-ex h2 {
    margin-bottom: 40px;
  }
}
@media (max-width: 1023px) {
  .sidebar-ex h2 {
    font-size: 48px;
    margin-bottom: 24px;
  }
}
@media (max-width: 767px) {
  .sidebar-ex h2 {
    font-size: 36px;
    max-width: 220px;
  }
}
.sidebar-ex h2 span {
  font-size: 32px;
  font-weight: 500;
  position: absolute;
  top: 10%;
  left: 55%;
}
@media (max-width: 1023px) {
  .sidebar-ex h2 span {
    font-size: 24px;
  }
}
@media (max-width: 767px) {
  .sidebar-ex h2 span {
    font-size: 16px;
    top: 6%;
    left: 46%;
  }
}

.box-blog {
  padding: 103px 0 200px 0;
}
@media (max-width: 1600px) {
  .box-blog {
    padding: 100px 0;
  }
}
@media (max-width: 1400px) {
  .box-blog {
    padding: 80px 0;
  }
}
@media (max-width: 1023px) {
  .box-blog {
    padding: 48px 0;
  }
}
@media (max-width: 767px) {
  .box-blog {
    padding: 24px 0 48px 0;
  }
}
.box-blog .title {
  margin-bottom: 40px;
  text-transform: uppercase;
}
@media (max-width: 1400px) {
  .box-blog .title {
    margin-bottom: 24px;
  }
}
@media (max-width: 767px) {
  .box-blog .title {
    margin-bottom: 12px;
  }
}
.box-blog .col-md-4 {
  margin-top: 56px;
}
@media (max-width: 1400px) {
  .box-blog .col-md-4 {
    margin-top: 40px;
  }
}
@media (max-width: 767px) {
  .box-blog .col-md-4 {
    margin-top: 20px;
    max-width: 100%;
    flex: 0 0 100%;
  }
}

.content-single {
  max-width: 888px;
  margin: 0 auto;
  width: 100%;
  line-height: 1.5;
}
.content-single p {
  margin-bottom: 20px;
}

.title-single {
  margin-bottom: 66px;
}
@media (max-width: 1023px) {
  .title-single {
    margin-bottom: 32px;
  }
}
.title-single h1 {
  font-size: 80px;
  font-weight: bold;
  line-height: 1;
}
@media (max-width: 1600px) {
  .title-single h1 {
    font-size: 60px;
  }
}
@media (max-width: 1400px) {
  .title-single h1 {
    font-size: 48px;
  }
}
@media (max-width: 1023px) {
  .title-single h1 {
    font-size: 32px;
  }
}

.box-blog-single {
  padding: 47px 0 190px 0;
}
@media (max-width: 1600px) {
  .box-blog-single {
    padding: 45px 0 100px 0;
  }
}
@media (max-width: 1023px) {
  .box-blog-single {
    padding: 45px 0 60px 0;
  }
}
@media (max-width: 767px) {
  .box-blog-single {
    padding: 24px 0 48px 0;
  }
}
.box-blog-single .title {
  margin-top: 162px;
}
@media (max-width: 1600px) {
  .box-blog-single .title {
    margin-top: 100px;
  }
}
@media (max-width: 1023px) {
  .box-blog-single .title {
    margin-top: 40px;
  }
}
.box-blog-single .title h2 {
  font-size: 64px;
}
@media (max-width: 1023px) {
  .box-blog-single .title h2 {
    font-size: 32px;
  }
}

.main_content {
  column-gap: 10px;
  width: 100%;
  column-count: 8;
}
@media (max-width: 767px) {
  .main_content {
    column-gap: 5px;
    column-count: 5;
  }
}
.main_content .picture_wrapper {
  margin-bottom: 10px;
}
@media (max-width: 767px) {
  .main_content .picture_wrapper {
    margin-bottom: 5px;
  }
}
.main_content .picture_wrapper a {
  display: flex;
  align-items: center;
  justify-content: center;
}
.main_content .picture_wrapper img {
  height: 100%;
  width: 100%;
  object-fit: cover;
  border-radius: 2px;
}

.box-banner {
  padding: 60px 0 0 0;
}
@media (max-width: 767px) {
  .box-banner {
    padding: 12px 0 0 0;
  }
}
.box-banner .container {
  max-width: 1440px;
}

.bottom-gallery {
  max-width: 848px;
  margin-left: auto;
  margin-top: 35px;
}
@media (max-width: 1600px) {
  .bottom-gallery {
    max-width: max-content;
  }
}
@media (max-width: 767px) {
  .bottom-gallery {
    max-width: 100%;
    text-align: center;
    margin: 0 auto;
    padding: 24px 0;
  }
}
.bottom-gallery h1 {
  font-size: 124px;
  font-weight: bold;
  line-height: 1;
  margin-bottom: 24px;
}
@media (max-width: 1600px) {
  .bottom-gallery h1 {
    font-size: 100px;
  }
}
@media (max-width: 1400px) {
  .bottom-gallery h1 {
    font-size: 80px;
  }
}
@media (max-width: 1023px) {
  .bottom-gallery h1 {
    font-size: 48px;
  }
}
@media (max-width: 767px) {
  .bottom-gallery h1 {
    font-size: 36px;
    margin-bottom: 12px;
  }
}
.bottom-gallery .desc {
  max-width: 445px;
  position: relative;
  font-size: 20px;
  font-weight: 500;
  display: flex;
  align-items: center;
  justify-content: center;
}
@media (max-width: 1400px) {
  .bottom-gallery .desc {
    font-size: 18px;
  }
}
@media (max-width: 1023px) {
  .bottom-gallery .desc {
    font-size: 14px;
  }
}
.bottom-gallery .desc svg {
  position: absolute;
  top: 0;
}
@media (max-width: 1023px) {
  .bottom-gallery .desc svg {
    width: 10px;
    height: auto;
  }
}
@media (max-width: 767px) {
  .bottom-gallery .desc svg {
    display: none;
  }
}
.bottom-gallery .desc svg:first-child {
  left: 0;
}
.bottom-gallery .desc svg:last-child {
  right: 0;
}
.bottom-gallery .desc p {
  padding: 0 35px;
}
@media (max-width: 1023px) {
  .bottom-gallery .desc p {
    padding: 0 20px;
  }
}
@media (max-width: 767px) {
  .bottom-gallery .desc p {
    padding: 0;
  }
}

.item-gallery {
  position: fixed;
  width: 550px;
  height: 100%;
  right: -550px;
  top: 0;
  background: #fff;
  z-index: 13;
  transition: 0.4s all !important;
  padding: 32px;
  overflow: auto;
}
@media (max-width: 767px) {
  .item-gallery {
    width: 100%;
    padding: 20px;
    right: -100%;
  }
}
.item-gallery.active {
  right: 0;
}
.item-gallery .txt-info-gallery {
  position: relative;
}
.item-gallery .txt-info-gallery h2 {
  margin-bottom: 24px;
  font-size: 32px;
  font-weight: bold;
}
@media (max-width: 1600px) {
  .item-gallery .txt-info-gallery h2 {
    font-size: 26px;
  }
}
@media (max-width: 1200px) {
  .item-gallery .txt-info-gallery h2 {
    font-size: 20px;
  }
}
@media (max-width: 767px) {
  .item-gallery .txt-info-gallery h2 {
    margin-bottom: 20px;
  }
}
.item-gallery .txt-info-gallery h3 {
  margin-bottom: 16px;
  font-size: 24px;
  font-weight: bold;
}
@media (max-width: 1600px) {
  .item-gallery .txt-info-gallery h3 {
    font-size: 20px;
  }
}
@media (max-width: 1200px) {
  .item-gallery .txt-info-gallery h3 {
    font-size: 18px;
  }
}
.item-gallery .txt-info-gallery p {
  margin-bottom: 4px;
}
.item-gallery .txt-info-gallery strong {
  font-weight: 500;
}
.item-gallery .avarta {
  margin-bottom: 32px;
}
.item-gallery .close-galley {
  position: absolute;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  top: 0;
  right: 0;
}
@media (max-width: 767px) {
  .item-gallery .close-galley {
    top: -4px;
  }
  .item-gallery .close-galley svg {
    width: 32px;
    height: auto;
  }
}

.overlay {
  background: #000000;
  opacity: 0;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: 12;
  pointer-events: none;
}
.overlay.active {
  opacity: 0.75;
}

/*# sourceMappingURL=style.cs.map */
