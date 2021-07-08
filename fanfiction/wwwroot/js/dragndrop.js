function stopDefault(event) {
    event.preventDefault();
    event.stopPropagation();
}
function dragOver(label, text) {
    label.style.animationName = "dropbox";
    label.innerText = text;
}
function dragLeave(label) {
    label.style.animationName = "";
  
        if (localStorage.key('lang') === "en")   label.innerText = langArr.en["Drag-n-drop"]
        else  if (localStorage.key('lang') === "ru")  label.innerText = langArr.ru["Drag-n-drop"]
        else label.innerText = langArr.ru["Drag-n-drop"]
   
}
function addFilesAndSubmit(event) {
    var files = event.target.files || event.dataTransfer.files;
    var field = document.getElementById("files-field");
    field.files = files;
    submitFilesForm(field.form);
}
function submitFilesForm(form) {
    var label = document.getElementById("files-label");
    dragOver(label, getUploading());
    if(!FormData) {
     
        return false;
    }
    var fd = new FormData();
    for (var i = 0; i < form.files.files.length; i++) {
        var field = form.files;
        fd.append(field.name, field.files[i], field.files[i].name);
    }
    fd.append(form.elements[0].name, form.elements[0].value); // must append the AntiForgeryToken to the form data
    var progress = document.getElementById("files-progress");
    var x = new XMLHttpRequest();
    if (x.upload) {
        x.upload.addEventListener("progress", function (event) {
  
        });
    }
    x.onreadystatechange = function () {
        if (x.readyState == 4) {
            progress.innerText = progress.style.width = "";
            form.files.value = "";
            dragLeave(label); // this will reset the text and styling of the drop zone
            if (x.status == 200) {
                var images = x.responseText.split('|');
                for (var i = 0; i < images.length; i++) {
                    var img = document.createElement("img");
                    img.src = images[i];
                   
                    document.getElementById("uploaded-files").appendChild(img);
                }
               // location.reload()
            }
            else if(x.status == 500) {
                alert(x.responseText); // do something with the server error
            }
            else {
                alert(x.status + ": " + x.statusText);
            }
        }
    };
    x.open(form.method, form.action, true);
    x.send(fd);
    
    return false; // do not forget this
}

function showArea()
{
    let area = document.getElementById("drag-n-drop-avatar")
    area.classList.toggle("show")
}
document.addEventListener('click', function(event) {
    var e=document.getElementById('drag-n-drop-avatar');
    var d = document.getElementById('edit-photo');
    if (!e.contains(event.target) && !d.contains(event.target))
    {
        e.classList.remove("show")
    }
});

function getUploading()
{
    if (localStorage.key('lang') === "en") return langArr.en.Uploading
    else  if (localStorage.key('lang') === "ru") return langArr.ru.Uploading
    else return langArr.ru.Uploading
}

