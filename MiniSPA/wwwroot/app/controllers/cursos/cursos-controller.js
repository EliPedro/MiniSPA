'use strict';

app.controller("CursosController", function ($scope, bootstrappedData) {
    $scope.cursos = bootstrappedData.cursos;
});