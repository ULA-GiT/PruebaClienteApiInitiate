/// <reference path="../jquery-2.1.1.js" />
/// <reference path="../underscore.js" />
$(document).ready(function () {
    var domain = "soce.int";
    var usr = "alfresco"
    $.getJSON("http://192.168.110.10/InitiateApi/api/Initiates/" + domain + "/" + usr)
          .done(function (data) {
              var miObjeto = JSON.parse(data)
              var tabla = $("#tabla");
              miObjeto.forEach(function (v, i) {
                  var tr = $("<tr></tr>");
                  tabla.append(tr);

                  var td = $("<td>" + v.NombreProceso + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.VersionProceso + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.NombreTarea + "</td>");
                  tr.append(td);

               });
          });
    });