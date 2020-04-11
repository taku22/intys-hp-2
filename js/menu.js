const menu                = document.getElementById('menu');
const navigationContainer = document.getElementById('navigation-container');
const arrow               = document.getElementById('arrow');
const arrowIsOpened       = document.getElementById('arrow-is-opened');
const menuList            = document.getElementById('menu-list');

menu.addEventListener('click',function(){
    menu.classList.toggle('menu-is-opened');
    navigationContainer.classList.toggle('navigation-container-is-opened');
    arrow.classList.toggle('dis-arrow');
    arrowIsOpened.classList.toggle('dis-arrow');
    menuList.classList.toggle('dis-menu-list');
})