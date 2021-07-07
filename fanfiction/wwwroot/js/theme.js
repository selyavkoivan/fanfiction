let themeArr = ["light-theme", "dark-theme"];

let page = document.querySelector('.page');
let themeButton = document.querySelector('.theme-button');




themeButton.onclick = function () {
    themeArr.forEach(theme => {
        
        if(page.classList.toggle(theme) === true) localStorage.setItem("theme", theme)
        else page.classList.remove(theme)
        
    })
};


function changeThemeOnLoad() {

    setTheme()
    setLanguage()
}

function setTheme()
{
    if (localStorage.getItem("theme") !== null) {
        themeArr.forEach(theme => { page.classList.remove(theme); })
        page.classList.add(localStorage.getItem("theme"))
    }
    else {
        localStorage.setItem("theme", "light-theme")
        page.classList.add('light-theme')
    }
}

function setLanguage()
{
    if (readCookie('lang') == null) {
       document.cookie = "lang=ru"
        localStorage.setItem("lang", "ru")
      
    }
    textTranslation(readCookie('lang'))
}

$(function() {
    $('.translate').click(function() {
        const lang = $(this).attr('id')
        document.cookie = "lang=" + lang;
        localStorage.setItem("lang", lang)
        textTranslation(lang)
    });
});

function textTranslation(lang)
{
   
    $('input.lang').each(function(index, item) {
        $(this).attr("placeholder",
            langArr[lang][$(this).attr('key')]
        )
    });

    $('.lang').each(function(index, item) {
        $(this).text(
            langArr[lang][$(this).attr('key')]
        )
    });
}

function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for(var i=0;i < ca.length;i++) {
        var c = ca[i];
        while (c.charAt(0)==' ') c = c.substring(1,c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
    }
    return null;
}
