import AdyenCheckout from "@adyen/adyen-web";


window.createAdyenCheckout = function (paymentMethods, paymentClient, orderID) {
    const paymentMethodsObject = JSON.parse(paymentMethods);
    const configuration = {
        paymentMethodsResponse: paymentMethodsObject, 
        clientKey: "test_CIXAPNBW2JERLEJ6GYYC3WBLVMO2HIZ3",
        locale: "nl-NL",
        environment: "test",
        onSubmit: (state, dropin) => {
            paymentClient.invokeMethodAsync('MakePayment', state.data, orderID)
                .then(responseString => {
                    var response = JSON.parse(responseString);
                    if (response.action) {
                        dropin.handleAction(response.action);
                    } else {
                        const startPos = 'Yidi_checkoutChallenge'.length;
                        const paymentId = response.merchantReference.substring(startPos);
                        window.location.replace(`checkout?paymentid=${paymentId}`);
                    }
                })
                .catch(error => {
                    throw Error(error);
                });
        },
        onAdditionalDetails: (state, dropin) => {
            // Your function calling your server to make a `/payments/details` request
            makeDetailsCall(state.data)
                .then(response => {
                    if (response.action) {
                        dropin.handleAction(response.action);
                    } else {
                        // I think that we never hit here perhaps with other payment methods. 
                        console.warn('no handling implemented for final result', response);
                    }
                })
                .catch(error => {
                    throw Error(error);
                });
        },
        paymentMethodsConfiguration: {
            card: { 
                hasHolderName: true,
                holderNameRequired: true,
                enableStoreDetails: true,
                hideCVC: false, 
                name: 'Credit or debit card',
                billingAddressRequired: true
            }
        }
    };

    const checkout = new AdyenCheckout(configuration);
    const dropin = checkout.create('dropin').mount('#dropin-container');
}
