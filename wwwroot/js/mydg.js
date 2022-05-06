const { hasUncaughtExceptionCaptureCallback } = require("process");

function funcDropDown(_gridId)
{
    //alert("dropdown");
    document.getElementById(nameOf("myDropdown",_gridId)).classList.toggle("show");

}
function addRecord(controller,action)
{
    var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action;
    window.location.href = url2;
}
function rowSelected(_mxrow,_gridId)
{
    var _nrsel=0;
    var _maxrows = parseInt(_mxrow);
    for (var _nri=1;_nri<=_maxrows;_nri++)
    {
            try{
            ckBox=document.getElementById(nameOf(_nri.toString().trim(),_gridId));
            if (ckBox.checked){
                _nrsel=_nri;
                break; }
            }
            catch{break;}
    }
    return _nrsel;
}
function actionClick(controller,action,_maxrow,_gridId)
{
    //alert("action");
    var _nrsel=0;
    _nrsel = parseInt(rowSelected(_maxrow,_gridId));
    if (_nrsel>0)
    {
        var checkbox = document.getElementById(nameOf(_nrsel.toString(),_gridId));
        _id = checkbox.value.toString();
        var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id;
        window.location.href = url2;
    }
}
function rowClick(_nr,controller,action,_gridId)
{
    var _nrow = parseInt(_nr);
    var checkbox = document.getElementById(nameOf(_nr.toString(),_gridId));
    _id = checkbox.value.toString();
    var url2=window.location.protocol+"//"+window.location.hostname+":"+window.location.port+"/"+controller+"/"+action+"/"+_id;
    window.location.href = url2;
}
function sortTable(_ncol,_gridId )
{
    var sortorder = getCookie(cookieName("sortorder",_gridId))
    var _sortorder = parseInt(sortorder);
    if (_sortorder ==0){sortorder=1;}
    else{sortorder =0;}
    document.cookie = cookieName("sortorder",_gridId)+"="+sortorder.toString();
    var _mcolumn = parseInt(_ncol);
    //alert(_mcolumn);
    document.cookie = cookieName("colorderton",_gridId)+"="+_mcolumn.toString();
    document.cookie = cookieName("rowselected",_gridId)+"=0";
    document.cookie = cookieName("currentpage",_gridId)+"=0";
    var url=window.location = window.location.href;//.split("?")[0];
    window.location.href = url;

}
function filterTable(_ncol,_gridId )
{
    var _texttofilter = document.getElementById(nameOf('filter-'+_ncol.toString(),_gridId)).value;
    document.cookie = cookieName("filterby-"+_ncol.toString(),_gridId)+"="+_texttofilter.toString();
    
    var current_page=1;   //cuando inicia o resetea un filtro pasa a la primera pagina del resultado
    document.cookie = cookieName("currentpage",_gridId)+"="+current_page.toString();

    //elimina los seleccionados 
    ////uncheck_all_except(0,_mxrow,_gridId)
    document.cookie = cookieName("rowselected",_gridId)+"=0";
    document.cookie = cookieName("proselected",_gridId)+"=0";

    var url=window.location = window.location.href;//.split("?")[0];
    window.location.href = url;

}
function uncheck_all_except(_nr,_mxrow,_gridId)
{
    var _maxrows = parseInt(_mxrow);
    var _nrow = parseInt(_nr);
    for (var _nri=1;_nri<=_maxrows;_nri++)
    {
        if (_nri==_nrow){
        }
        else {
            try{
            ckBox=document.getElementById(nameOf(_nri.toString().trim(),_gridId));
            if (ckBox.checked){
                ckBox.checked=false;
                var trRow=document.getElementById(nameOf('trRow'+(_nri.toString().trim()),_gridId));
                if (_nri%2==0 )
                {trRow.className = "line-text-pri";}
                else{trRow.className ="line-text-alt";}
            break;}}
            catch(error){
                //alert(error);
                break;}
        }
    }
}
function selectionchange(_nr,_mxrow,_gridId)
{   
    var _npag = parsenum(getCookie(cookieName("currentpage",_gridId)));
    var _maxrows = parseInt(_mxrow);
    var _nrow = parseInt(_nr);
    var checkbox = document.getElementById(nameOf(_nr.toString(),_gridId));
    var btnact = document.getElementById(nameOf("btn_dropdn",_gridId));
    var _id = checkbox.value.toString();  //no usado de momento
    var div = document.getElementById(nameOf('dd_div_btn',_gridId));


    if (checkbox.checked){
        div.style.visibility = 'visible';
        //uncheck_all_except(_nr,_mxrow);
        document.getElementById(nameOf('trRow'+_nrow.toString().trim(),_gridId)).className = 'line-text-sel';
        document.cookie = cookieName("rowselected",_gridId)+"="+_nrow.toString();
        document.cookie = cookieName("proselected",_gridId)+"="+_npag.toString();
        //document.cookie = "ridselected="+_id.toString();
        //////btnact.value=_id.toString();
    }
    else{
        div.style.visibility = 'hidden';
        var trRow=document.getElementById(nameOf('trRow'+_nrow.toString().trim(),_gridId));
        if (_nrow%2==0 )
        {trRow.className = "line-text-pri";}
        else{trRow.className ="line-text-alt";}

        document.cookie = cookieName("rowselected",_gridId)+"=0";
        document.cookie = cookieName("proselected",_gridId)+"=0";
        //document.cookie = "ridselected=0";
        ////////btnact.value="0";
    }
    uncheck_all_except(_nr,_mxrow,_gridId);
    //var url=window.location = window.location.href;//.split("?")[0];
    //window.location.href = url;

}
function prevPage(_current_page,_gridId)
{
    var current_page = parseInt(_current_page);
    if (current_page > 1) {
        current_page--;
    }
    var url=window.location = window.location.href;//.split("?")[0];
    //url +=  "?current_page=" + current_page.toString() ; //'?param=1'
    //alert("_pre:"+url.toString());

    //var _tcur_page = document.getElementById('curpage');
    //_tcur_page.value=current_page.toString();
    document.cookie = cookieName("currentpage",_gridId)+"="+current_page.toString();
    //alert(current_page);
    window.location.href = url;
    
}
function nextPage(_current_page,_num_pages,_gridId)
{
    var current_page = parseInt(_current_page);
    var num_pages = parseInt(_num_pages);
    if (current_page < num_pages) {
        current_page++;
    }
    //const ret = [];
    //ret.push(encodeURIComponent("current_page") + '=' + encodeURIComponent(current_page));

    var url=window.location = window.location.href;//.split("?")[0];
    //alert(cookieName("currentpage",_gridId)+"="+current_page.toString());
    document.cookie = cookieName("currentpage",_gridId)+"="+current_page.toString();
    //alert(getCookie( "_"+_gridId+"-"+"currentpage"));
    //alert(getCookie(cookieName("currentpage",_gridId)));
    //alert(current_page);

    window.location.href = url;
    
}
function gotoPage(_current_page,_num_pages,_gridId)
{
    var _new_page = document.getElementById(nameOf('newpage',_gridId)).value;
    try{
    var new_page = parseInt(_new_page);
    var num_pages = parseInt(_num_pages);
    }
    catch{new_page=_current_page;}
    if (new_page > num_pages) {
        new_page=num_pages;
    }
    if (new_page < 1) {
        new_page=1;
    }
    if (isNaN(new_page)){new_page=_current_page;}
    //const ret = [];
    //ret.push(encodeURIComponent("current_page") + '=' + encodeURIComponent(current_page));

    var url=window.location = window.location.href;//.split("?")[0];
    //url +=  "?current_page=" + new_page.toString() ; //'?param=1'
    //url += ret ; //'?param=1'
    //alert("_nex:"+url.toString());

    document.cookie = cookieName("currentpage",_gridId)+"="+new_page.toString();
    //alert(new_page);

    window.location.href = url;
    
}
function parsenum(x)
{
    x=parseInt(x);
    if (isNaN(x)){x=0;}
    return x;

}
function myFunc() {

    //lo debe hacer para todos los controles grid  (no conocemos el control en este momento)
    //debemos disponer de una coleccion de los controles grid que hay en la pagina 
    //tal vez pueden estar en una cookie
    //y hacer esto para cada uno de ellos
    var cookinam = cookieNameS("gridcount");
    var gridcount = getCookie(cookinam);
    for (i=1;i<=gridcount;i++)
    {   
        var _gridId = i.toString();
        var div = document.getElementById(nameOf('dd_div_btn',_gridId));
        //var _tcur_page = document.getElementById('curpage').value;
        let x = parsenum(getCookie(cookieName("currentpage",_gridId)));
        try{
            document.getElementById(nameOf('curpage',_gridId)).value=x;}
        catch (error) {}
    
        let n = getCookie(cookieName("rowselected",_gridId));
        let p = getCookie(cookieName("proselected",_gridId));
        //alert ("MyFunc cuupage"+x.toString()+"control "+_gridId.toString()+" rowsel "+ n.toString()+" prosel " + p.toString());
        try{
            if (p==x && p>0){
                document.getElementById(nameOf(n,_gridId)).checked=true;
                if (n>0){div.style.visibility = 'visible';}
                else{div.style.visibility = 'hidden';}
            }
            else{div.style.visibility = 'hidden';}
        }
        catch(error){div.style.visibility = 'hidden';}

        //var recsel = parsenum(n);
    }
}
function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for(let i = 0; i <ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
    }
function cookieName(_cookie,_gridId)
{
    //var uId = document.getElementById(_gridId+'-'+'cntrl_id').value.Tostr();
    var _newName="_"+_gridId.toString()+"-"+_cookie.toString(); 
    return _newName;
}
function cookieNameS(_cookie)
{
    //var uId = document.getElementById(_gridId+'-'+'cntrl_id').value.Tostr();
    var _newName=_cookie.toString(); 
    return _newName;
}

function nameOf(_control,_gridId)
{
    return "_"+_gridId+"-"+_control;
}