$('#myModal').modal('show');
$('.collapse').collapse();

/*Search box js*/
//let searchform = document.querySelector('c')
//document.querySelector('#search-btn').OnClick = () => {
//    searchform.classList.toggle('active');
//}

function toggle_visibility(id) {
    var e = document.getElementById(id);
    if (e.style.display == 'block')
        e.style.display = 'none';
    else
        e.style.display = 'block';
}