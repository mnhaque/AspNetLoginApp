authenticationApp.controller('LoginCtrl', ['$scope', function ($scope) {
        var _this = this;

        
        _this.submit = function () {
            _this.user = {
                email: $scope.email,
                password: $scope.password
            };
            alert(0);
            //var promise = CommonAPI.commonAPICall(Config.API_TYPE_POST, url, _this.user);
            /*promise.then(function (result) {
              if (result.success) {
                AuthToken.setToken(result.data.token);
                AlertProviderService.showAlert(Config.ALERT_TYPE_SUCCESS, 'You are now logged in. Welcome, ' + _this.user.email + '!');
              } else {
                _this.warningAlert();
              }
            });*/
        }
    }
]);