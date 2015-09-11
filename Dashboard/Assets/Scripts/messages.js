angular.module("mainModule")
    .controller("messagesController", function ($scope, $http) {
        $scope.messagesCount = 0;
        $scope.messages = [];

        $wsRequestUrl = $wsNomina + "dashboard/getNewMessagesByIdUser/" + $idUser;

        $http({
            method : 'GET',
            url: $wsRequestUrl,
            headers: { 'Accept':'application/json'}
        })
        .success(function (data, status) {
            var $msgCount = 0;
            for (var k in data)++$msgCount;

            $scope.messagesCount = $msgCount;
            $scope.messages = data;
        })
        .error(function(data, status) {
            alert("Error al obtener la sección de mensajes!!!");
        });
    });
