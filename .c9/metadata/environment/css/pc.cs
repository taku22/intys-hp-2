{"filter":false,"title":"pc.cs","tooltip":"/css/pc.cs","undoManager":{"mark":0,"position":0,"stack":[[{"start":{"row":0,"column":0},"end":{"row":908,"column":1},"action":"insert","lines":["",".section-title h1 {","    font-size: 7.2rem;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","}","","/*個別*/","",".header {","    position: relative;","    width: 100%;","    height: 900px;","    z-index: 2;","}","",".navigation-container {","    position: fixed;","    top: 0;","    right: -938.76px;","    width: 1325.18px;","    height: 62.99px;","    margin-top: 33px;","    background: #ff1a5b;","    z-index: 4;","    transition: all 0.5s;","}","",".navigation-container-is-opened {","    position: fixed;","    top: 0;","    right: 0;","    width: 1325.18px;","    height: 62.99px;","    margin-top: 33px;","    background: #ff1a5b;","    z-index: 4;","}","",".arrow {","    display: inline-block;","    height: 5px;","    width: 120px;","    background-color: #FFF;","    position: relative;","    top: 15px;","    z-index: 4;","    transition: all 0.5s;","","}","",".arrow:before {","    position: absolute;","    content: \"\";","    width: 40px;","    height: 8px;","    background: #FFF;","    transform: rotate(-45deg);","    right: 83px;","    top: -16.5px;","    z-index: 4;","    transition: all 0.5s;","}","",".arrow-is-opened {","    display: inline-block;","    height: 5px;","    width: 120px;","    background-color: #FFF;","    position: relative;","    top: 15px;","    z-index: 4;","    transition: all 0.5s;","}","",".arrow-is-opened:before {","    position: absolute;","    content: \"\";","    width: 40px;","    height: 8px;","    background: #FFF;","    transform: rotate(45deg);","    right: -3.5px;","    top: -16.5px;","    z-index: 4;","    transition: all 0.5s;","}","",".dis-arrow {","    display: none;","}","",".logo {","    margin-top: 8px;","    width: 178px;","    height: 83px;","    z-index: 5;","}","","",".top-image {","    width: 100%;","    height: 100%;","}","",".menu {","    position: relative;","    top: -90px;","    left: 300px;","    width: 36px;","    height: 43.88px;","    margin: 20px 36px 13px 10px;","    cursor: pointer;","    transition: all 0.5s;","","}","",".menu-is-opened {","    position: relative;","    top: -90px;","    left: 1238.76px;","    width: 36px;","    height: 43.88px;","    margin: 20px 36px 13px 10px;","    cursor: pointer;","}","",".dis-menu-list {","    display: none;","    transition: all 2s;","}","",".menu-list {","    padding-top: 14px;","    margin-right: 100px;","    float: right;","    transition: all 2s;","}","",".menu-list li {","    float: left;","    padding-left: 46px;","    font-size: 3.6rem;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","}","",".menu-list a {","    color: #FFF;","}","",".menu-line {","    position: absolute;","    left: 10px;","    height: 2px;","    width: 32px;","    background-color: #FFF;","    transition: all 0.3s;","}","",".line01 {","    top: 5px;","}","",".line02 {","    top: 17px;","}","",".line03 {","    top: 29px;","}","",".menu-is-opened .line01 {","    transform: rotate(45deg);","    top: 20px;","}","",".menu-is-opened .line02 {","    width: 0px;","}","",".menu-is-opened .line03 {","    transform: rotate(-45deg);","    top: 20px;","}","",".wrapper {","    background: linear-gradient(270deg, #d38bc8, #aec3e9);","}","",".content-wrapper {","    position: relative;","    width: 960px;","    height: 100%;","    margin: 0 auto;","}","","/*about部分*/","",".about {","    width: 100%;","    height: 1460px;","    z-index: 2;","}","",".title-about {","    position: absolute;","    top: 70px;","    right: 95%;","    z-index: 2;","}","",".title-about h1 {","    color: #e2038b;","    z-index: 2;","}","",".service-container {","    width: 960px;","    height: 100%;","    margin: 0 auto;","    padding-top: 315px;","    padding-bottom: 240px;","}","",".service {","    position: relative;","    display: block;","    width: 100%;","}","",".service h2 {","    position: absolute;","    left: 12.5%;","    font-size: 6rem;","    line-height: 50px;","    color: #fffeff;","    z-index: 3;","}","",".service p {","    display: inline-block;","    width: 100%;","    position: absolute;","    left: 33%;","    padding-left: 50px;","    font-size: 2.9rem;","    font-family: YuGothic;","    color: #0056c0;","    z-index: 2;","}","",".design {","    height: 331px;","    padding-bottom: 89px;","}","",".system {","    height: 255px;","    padding-bottom: 120px;","}","","/*member部分*/","",".member {","    width: 100%;","    height: 1234px;","    z-index: 2;","}","",".title-member {","    position: absolute;","    top: 1374px;","    right: 90%;","    color: #0056c0;","    z-index: 2;","}","",".member-img-top {","    position: absolute;","    top: 1587px;","    right: 38%;","    width: 720px;","    height: 255px;","    background: #a2a2a2;","    z-index: 2;","}","",".member-name-top-jp-name {","    position: absolute;","    top: 1621px;","    left: 54.1%;","    font-family: YuGothic;","    font-size: 6rem;","    color: #0056c0;","    z-index: 3;","}","",".member-name-top-alphabet-name {","    position: absolute;","    top: 1692px;","    left: 59.2%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    font-size: 3.6rem;","    color: #0056c0;","    z-index: 3;","}","",".member-description-top-text01 {","    position: absolute;","    top: 1500px;","    left: 85.9%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #0056c0;","    font-size: 6rem;","    z-index: 3;","}","",".member-description-top-text02 {","    position: absolute;","    top: 1563px;","    left: 102.229%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #0056c0;","    font-size: 6rem;","    z-index: 3;","}","",".member-description-top-text03 {","    position: absolute;","    top: 1605px;","    left: 88.54%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #0056c0;","    font-size: 6rem;","    z-index: 3;","}","",".member-description-top-text04 {","    position: absolute;","    top: 1689px;","    left: 108%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #ff1a5b;","    font-size: 6rem;","    z-index: 3;","}","",".member-img-bottom {","    position: absolute;","    top: 1914px;","    right: 38%;","    width: 720px;","    height: 255px;","    background: #a2a2a2;","    z-index: 2;","}","",".member-name-bottom-jp-name {","    position: absolute;","    top: 1946px;","    left: 53.6%;","    font-family: YuGothic;","","    font-size: 6rem;","    color: #0056c0;","    z-index: 3;","}","",".member-name-bottom-alphabet-name {","    position: absolute;","    top: 2016px;","    left: 59.3%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    font-size: 3.6rem;","    color: #0056c0;","    z-index: 3;","}","",".member-description-bottom-text01 {","    position: absolute;","    top: 1900px;","    left: 91.875%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #ff1a5b;","    font-size: 6rem;","    z-index: 3;","}","",".member-description-bottom-text02 {","    position: absolute;","    top: 2064px;","    left: 80.3%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #0056c0;","    font-size: 6rem;","    z-index: 3;","}","",".member-description-bottom-text03 {","    position: absolute;","    top: 2066px;","    left: 102.3%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #0056c0;","    font-size: 6rem;","    z-index: 3;","}","",".member-description-bottom-text04 {","    position: absolute;","    top: 2140px;","    left: 90.93%;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","    color: #0056c0;","    font-size: 6rem;","    z-index: 3;","}","","","/*blog部分*/","",".blog {","    width: 100%;","    height: 667px;","    z-index: 2;","}","",".title-blog {","    position: absolute;","    top: 2669px;","    right: 95%;","    color: #0056c0;","    z-index: 2;","}","",".blog-container {","    width: 100%;","    height: 100%;","}","",".blog-left {","    position: absolute;","    top: 2792px;","    left: -14.89%;","    z-index: 3;","}","",".blog-middle {","    position: absolute;","    top: 2792px;","    left: 31.4%;","    z-index: 3;","}","",".blog-right {","    position: absolute;","    top: 2792px;","    left: 77.7%;","    z-index: 3;","}","",".blog-img {","    width: 390px;","    height: 223px;","    background: #a2a2a2;","}","",".blog-data {","    font-family: YuGothic;","    font-weight: bold;","    color: #0056c0;","    font-size: 2.4rem;","}","",".blog-title {","    font-family: YuGothic;","    color: #0056c0;","    font-size: 3rem;","}","",".btn {","    position: absolute;","    top: 3131px;","    left: 110%;","    width: 100.81px;","    height: 34.94px;","    background: #FFF;","    border: 2px solid #afc1e8;","}","",".btn a {","    font-size: 2.4rem;","    line-height: 20px;","    font-family: \"PaneuropaRetroSoft-DemiBold\";","}","","/*footer部分*/","",".footer {","    width: 100%;","    height: 50px;","    background: #4b4b4b;","}","",".footer div {","    text-align: center;","}","",".footer small {","    font-size: 2rem;","    color: #FFF;","}","","/*図形左上からナンバリング*/","",".ro1 {","    position: absolute;","    top: -215px;","    left: -32.1%;","    width: 432px;","    height: 431px;","    border-radius: 50%;","    background-color: #0056c0;","    z-index: 1;","}","",".ro2 {","    position: absolute;","    top: 104px;","    left: 43.8%;","    width: 109px;","    height: 109px;","    border-radius: 50%;","    background-color: #0056c0;","    z-index: 1;","}","",".ro3 {","    position: absolute;","    top: 0;","    right: -16.25%;","    width: 294.43px;","    height: 294.37px;","    border-radius: 50%;","    border: 2px solid #0056c0;","    z-index: 1;","}","",".ro4 {","    position: absolute;","    top: 205px;","    left: -11.1%;","    width: 180.27px;","    height: 180.25px;","    border-radius: 50%;","    border: 2px solid #0056c0;","    z-index: 1;","}","",".ro5 {","    position: absolute;","    top: 284px;","    left: 6.25%;","    width: 136px;","    height: 136px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro6 {","    position: absolute;","    top: 218px;","    left: 109%;","    width: 213.46px;","    height: 213.46px;","    border-radius: 50%;","    background-color: #0056c0;","    z-index: 1;","}","",".ro7 {","    position: absolute;","    top: 556px;","    left: 62.8%;","    width: 72.41px;","    height: 72.4px;","    border-radius: 50%;","    border: 2px solid #0056c0;","    z-index: 1;","}","",".ro8 {","    position: absolute;","    top: 442px;","    left: 69.4%;","    width: 213.46px;","    height: 213.46px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro9 {","    position: absolute;","    top: 635px;","    left: -13.2%;","    width: 110.79px;","    height: 110.79px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro10 {","    position: absolute;","    top: 679px;","    left: -7%;","    width: 294.42px;","    height: 294.37px;","    border-radius: 50%;","    border: 2px solid #ff1a5b;","    z-index: 2;","}","",".ro11 {","    position: absolute;","    top: 723px;","    left: 100.7%;","    width: 160.78px;","    height: 160.75px;","    border-radius: 50%;","    border: 2px solid #ff1a5b;","    z-index: 1;","}","",".ro12 {","    position: absolute;","    top: 874px;","    left: 8.22%;","    width: 213.46px;","    height: 213.46px;","    border-radius: 50%;","    background-color: #0056c0;","    z-index: 1;","}","",".ro13 {","    position: absolute;","    top: 856px;","    left: 112%;","    width: 110.81px;","    height: 110.78px;","    border-radius: 50%;","    background-color: #0056c0;","    z-index: 1;","}","",".ro14 {","    position: absolute;","    top: 1060px;","    left: 35.5%;","    width: 213.46px;","    height: 213.46px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro15 {","    position: absolute;","    top: 1154px;","    left: -35%;","    width: 432px;","    height: 432px;","    border-radius: 50%;","    background-color: #ff7fa3;","    z-index: 1;","}","",".ro16 {","    position: absolute;","    top: 1496px;","    left: 43.0%;","    width: 125.92px;","    height: 125.96px;","    border-radius: 50%;","    background-color: #585fba;","    z-index: 1;","}","",".ro17 {","    position: absolute;","    top: 1465px;","    left: 82.8%;","    width: 252px;","    height: 252px;","    border-radius: 50%;","    background-color: #ff7fa3;","    z-index: 2;","}","",".ro18 {","    position: absolute;","    top: 1628px;","    left: 95.1%;","    width: 195.45px;","    height: 195.5px;","    border-radius: 50%;","    background-color: #585fba;","    z-index: 1;","}","",".ro19 {","    position: absolute;","    top: 1622px;","    left: 105%;","    width: 185.98px;","    height: 186.03px;","    border-radius: 50%;","    border: 2px solid #585fba;","    z-index: 1;","}","",".ro20 {","    position: absolute;","    top: 1771px;","    left: -18.5%;","    width: 142.73px;","    height: 142.73px;","    border-radius: 50%;","    border: 2px solid #ff7fa3;","    z-index: 1;","}","",".ro21 {","    position: absolute;","    top: 1842px;","    left: 12.3%;","    width: 112.92px;","    height: 112.92px;","    border-radius: 50%;","    background-color: #ff7fa3;","    z-index: 1;","}","",".ro22 {","    position: absolute;","    top: 1842px;","    left: 90%;","    width: 197.95px;","    height: 198px;","    border-radius: 50%;","    background-color: #585fba;","    z-index: 1;","}","",".ro23 {","    position: absolute;","    top: 1992px;","    left: 79.7%;","    width: 252px;","    height: 252px;","    border-radius: 50%;","    background-color: #ff7fa3;","    z-index: 1;","}","",".ro24 {","    position: absolute;","    top: 1975px;","    left: 95.1%;","    width: 258.01px;","    height: 258.01px;","    border-radius: 50%;","    border: 2px solid #ff7fa3;","    z-index: 1;","}","",".ro25 {","    position: absolute;","    top: 2099px;","    right: 116%;","    width: 165.94px;","    height: 166px;","    border-radius: 50%;","    background-color: #585fba;","    z-index: 1;","}","",".ro26 {","    position: absolute;","    top: 2066px;","    left: 21%;","    width: 268.9px;","    height: 269px;","    border-radius: 50%;","    border: 2px solid #585fba;","    z-index: 1;","}","",".ro27 {","    position: absolute;","    top: 2283px;","    left: 42.2%;","    width: 162.52px;","    height: 162.52px;","    border-radius: 50%;","    background-color: #ff7fa3;","    z-index: 1;","}","",".ro28 {","    position: absolute;","    top: 2360px;","    right: 87.4%;","    width: 432px;","    height: 432px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro29 {","    position: absolute;","    top: 2611px;","    left: 9%;","    width: 227.68px;","    height: 227.79px;","    border-radius: 50%;","    border: 2px solid #585fba;","    z-index: 2;","}","",".ro30 {","    position: absolute;","    top: 2727px;","    left: 25.729%;","    width: 134.47px;","    height: 134.47px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro31 {","    position: absolute;","    top: 2669px;","    left: 72%;","    width: 166.49px;","    height: 166.53px;","    border-radius: 50%;","    border: 2px solid #ff1a5b;","    z-index: 2;","}","",".ro32 {","    position: absolute;","    top: 2775px;","    left: 66.45%;","    width: 153.9px;","    height: 153.96px;","    border-radius: 50%;","    background-color: #585fba;","    z-index: 1;","}","",".ro33 {","    position: absolute;","    top: 2808px;","    left: 108.9%;","    width: 207.35px;","    height: 207.44px;","    border-radius: 50%;","    background-color: #585fba;","    z-index: 1;","}","",".ro34 {","    position: absolute;","    top: 2948px;","    left: 118.68%;","    width: 138.96px;","    height: 138.99px;","    border-radius: 50%;","    border: 2px solid #ff1a5b;","    z-index: 1;","}","",".ro35 {","    position: absolute;","    top: 3049px;","    left: 2.7%;","    width: 179.63px;","    height: 179.67px;","    border-radius: 50%;","    background-color: #ff1a5b;","    z-index: 1;","}","",".ro36 {","    position: absolute;","    top: 3149px;","    left: 15.93%;","    width: 130.58px;","    height: 130.61px;","    border-radius: 50%;","    border: 2px solid #585fba;","    z-index: 1;","}"],"id":1}]]},"ace":{"folds":[],"scrolltop":0,"scrollleft":0,"selection":{"start":{"row":10,"column":8},"end":{"row":10,"column":8},"isBackwards":false},"options":{"guessTabSize":true,"useWrapMode":false,"wrapToView":true},"firstLineState":0},"timestamp":1586787081267,"hash":"475351c607758137090245e0cb7aca1b58e84a05"}