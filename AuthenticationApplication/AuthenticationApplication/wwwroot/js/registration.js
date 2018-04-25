authenticationApp.controller('RegisterCtrl', ['$scope',
    function ($scope) {
        var _this = this;
        $scope.countries = {

            'USA': {
                'Alabama': ['Montgomery', 'Birmingham'],
                'California': ['Sacramento', 'Fremont'],
                'Illinois': ['Springfield', 'Chicago']
            },
            'India': {
                'Maharashtra': ['Pune', 'Mumbai', 'Nagpur', 'Akola'],
                'Madhya Pradesh': ['Indore', 'Bhopal', 'Jabalpur'],
                'Rajasthan': ['Jaipur', 'Ajmer', 'Jodhpur']
            },
            'Australia': {
                'New South Wales': ['Sydney'],
                'Victoria': ['Melbourne']
            }
        };

        $scope.GetSelectedCountry = function () {
            $scope.strCountry = $scope.countrySrc;
        };
        $scope.GetSelectedState = function () {
            $scope.strState = $scope.stateSrc;
        };
        _this.submit = function () {
            alert('ll');
            //_this.user = {
            //    email: $scope.email,
            //    password: $scope.password
            //};
            //var url = Config.BASE_URL + 'register';
            //var promise = $auth.signup(_this.user);
            //promise.then(function (result) {
            //    AlertProviderService.showAlert(Config.ALERT_TYPE_SUCCESS, 'You are now registered. Welcome, ' + result.data.user.email + '!');
            //}).catch(function (error) {
            //    if (error.status === 409) {
            //        AlertProviderService.showAlert(Config.ALERT_TYPE_WARNING, error.data.message);
            //    } else {
            //        AlertProviderService.showAlert(Config.ALERT_TYPE_WARNING, 'Could not register!!');
            //    }
            //});
            /*var promise = CommonAPI.commonAPICall(Config.API_TYPE_POST, url, _this.user);
            promise.then(function (result) {
              if (result.success) {
                AuthToken.setToken(result.data.token);
                AlertProviderService.showAlert(Config.ALERT_TYPE_SUCCESS, 'You are now registered. Welcome, ' + _this.user.email + '!');
              } else {
                if (result.status === 409) {
                  AlertProviderService.showAlert(Config.ALERT_TYPE_WARNING, result.error.message);
                } else {
                  AlertProviderService.showAlert(Config.ALERT_TYPE_WARNING, 'Could not register!!');
                }          
              }
            });*/
        };
    }
]);