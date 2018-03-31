(function () {
    'use strict';

    app.controller("EstudantesController", function ($scope, bootstrappedData) {
        $scope.estudantes = bootstrappedData.estudantes;
    });
})();
