(self.webpackChunkNpmJS=self.webpackChunkNpmJS||[]).push([[886],{391:(e,r,a)=>{"use strict";a.r(r),a.d(r,{default:()=>t});const t={payButton:"支払う","payButton.redirecting":"リダイレクトしています...",storeDetails:"次回のお支払いのため詳細を保存","creditCard.holderName":"カード上の名前","creditCard.holderName.placeholder":"Taro Yamada","creditCard.holderName.invalid":"無効なカード所有者名","creditCard.numberField.title":"カード番号","creditCard.numberField.placeholder":"1234 5678 9012 3456","creditCard.expiryDateField.title":"有効期限","creditCard.expiryDateField.placeholder":"MM/YY","creditCard.expiryDateField.month":"月","creditCard.expiryDateField.month.placeholder":"MM","creditCard.expiryDateField.year.placeholder":"YY","creditCard.expiryDateField.year":"年","creditCard.cvcField.title":"セキュリティーコード (CVC)","creditCard.cvcField.placeholder":"123","creditCard.storeDetailsButton":"次回のために保存します","creditCard.cvcField.placeholder.4digits":"4桁","creditCard.cvcField.placeholder.3digits":"3桁","creditCard.taxNumber.placeholder":"年月日（YYMMDD）/ 0123456789",installments:"分割回数",installmentOption:"%{times}x %{partialValue}",installmentOptionMonths:"%{times}か月","installments.oneTime":"一括払い","installments.installments":"分割払い","installments.revolving":"リボ払い","sepaDirectDebit.ibanField.invalid":"口座番号の入力間違い","sepaDirectDebit.nameField.placeholder":"J. Smith","sepa.ownerName":"名義","sepa.ibanNumber":"口座番号 (IBAN)","error.title":"エラー","error.subtitle.redirect":"画面の切り替え失敗にしました","error.subtitle.payment":"支払できませんでした","error.subtitle.refused":"カード会社で取引が承認されませんでした。","error.message.unknown":"不明なエラーが発生しました","idealIssuer.selectField.title":"銀行","idealIssuer.selectField.placeholder":"銀行を選択してください","creditCard.success":"認証が成功しました",loading:"読み込んでいます...",continue:"続ける",continueTo:"次へ進む：","wechatpay.timetopay":"%@をお支払い下さい。","wechatpay.scanqrcode":"QR コードをスキャンする",personalDetails:"個人情報",companyDetails:"会社情報","companyDetails.name":"会社名","companyDetails.registrationNumber":"登録番号",socialSecurityNumber:"ソーシャルセキュリティー番号",firstName:"名",infix:"敬称",lastName:"姓",mobileNumber:"携帯番号","mobileNumber.invalid":"無効な携帯電話番号",city:"市区",postalCode:"郵便番号",countryCode:"国コード",telephoneNumber:"電話番号",dateOfBirth:"生年月日",shopperEmail:"Eメールアドレス",gender:"性別",male:"男性",female:"女性",billingAddress:"ご請求住所",street:"番地",stateOrProvince:"都道府県",country:"国",houseNumberOrName:"部屋番号",separateDeliveryAddress:"別の配送先住所を指定してください",deliveryAddress:"配送先住所",zipCode:"郵便番号",apartmentSuite:"アパート名/部屋名",provinceOrTerritory:"州または準州",cityTown:"市区町村",address:"住所",state:"都道府県","creditCard.cvcField.title.optional":"セキュリティーコード(任意)","issuerList.wallet.placeholder":"ウォレットを選択してください",privacyPolicy:"プライバシーポリシー","afterPay.agreement":"AfterPayの%@で同意",paymentConditions:"支払条件",openApp:"アプリを開く","voucher.readInstructions":"手順を参照してください","voucher.introduction":"お買い上げありがとうございます。以下のクーポンを使用して、お支払いを完了してください。","voucher.expirationDate":"有効期限","voucher.alternativeReference":"別の参照","dragonpay.voucher.non.bank.selectField.placeholder":"プロバイダーを選択してください","dragonpay.voucher.bank.selectField.placeholder":"銀行を選択してください","voucher.paymentReferenceLabel":"支払の参照","voucher.surcharge":"%@ の追加料金を含む","voucher.introduction.doku":"お買い上げありがとうございます。以下の情報を使用して、お支払いを完了してください。","voucher.shopperName":"購入者氏名","voucher.merchantName":"業者","voucher.introduction.econtext":"お買い上げありがとうございます。以下の情報を使用して、お支払いを完了してください。","voucher.telephoneNumber":"電話番号","voucher.shopperReference":"購入者向け参考情報","voucher.collectionInstitutionNumber":"収納機関番号","voucher.econtext.telephoneNumber.invalid":"電話番号は10桁または11桁にしてください","boletobancario.btnLabel":"Boletoを生成する","boleto.sendCopyToEmail":"自分のメールアドレスにコピーを送信する","button.copy":"コピー","button.download":"ダウンロード","creditCard.storedCard.description.ariaLabel":"保存されたカードは％@に終了します","voucher.entity":"エンティティ",donateButton:"寄付する",notNowButton:"今はしない",thanksForYourSupport:"ご支援いただきありがとうございます。",preauthorizeWith:"次で事前認証する：",confirmPreauthorization:"事前承認を確認する",confirmPurchase:"購入を確認する",applyGiftcard:"利用する",giftcardBalance:"ギフトカードの残高",deductedBalance:"差し引き後残高","creditCard.pin.title":"PIN","creditCard.encryptedPassword.label":"カードのパスワードの最初の2桁","creditCard.encryptedPassword.placeholder":"12","creditCard.encryptedPassword.invalid":"パスワードが無効です","creditCard.taxNumber.label":"カード所有者の生年月日（YYMMDD）または法人登録番号（10桁）","creditCard.taxNumber.labelAlt":"法人登録番号（10桁）","creditCard.taxNumber.invalid":"カード所有者の生年月日または法人登録番号が無効です","storedPaymentMethod.disable.button":"削除","storedPaymentMethod.disable.confirmation":"保存されている支払方法を削除する","storedPaymentMethod.disable.confirmButton":"はい、削除します","storedPaymentMethod.disable.cancelButton":"キャンセル","ach.bankAccount":"銀行口座","ach.accountHolderNameField.title":"口座名義","ach.accountHolderNameField.placeholder":"Taro Yamada","ach.accountHolderNameField.invalid":"無効な口座名義","ach.accountNumberField.title":"口座番号","ach.accountNumberField.invalid":"口座番号の入力間違い","ach.accountLocationField.title":"ABAナンバー","ach.accountLocationField.invalid":"無効なABAナンバー","select.state":"都道府県を選択してください","select.stateOrProvince":"都道府県を選択してください","select.provinceOrTerritory":"州または準州を選択してください","select.country":"国を選択してください","select.noOptionsFound":"オプションが見つかりませんでした","select.filter.placeholder":"検索...","telephoneNumber.invalid":"無効な電話番号",qrCodeOrApp:"または","paypal.processingPayment":"支払いを処理しています...",generateQRCode:"QRコードを生成する","await.waitForConfirmation":"確認を待っています","mbway.confirmPayment":"MB WAYアプリで支払を確認する","shopperEmail.invalid":"Eメールアドレスが無効です","dateOfBirth.format":"DD/MM/YYYY","dateOfBirth.invalid":"18歳以上の方のみご利用いただけます","blik.confirmPayment":"バンキングアプリを開いて、支払を確認してください。","blik.invalid":"6つの数字を入力してください","blik.code":"6桁のコード","blik.help":"バンキングアプリからコードを取得してください。","swish.pendingMessage":"スキャン後、ステータスは最大10分間保留状態になります。この間に再度お支払いいただこうとすると、複数の請求が発生する場合があります。","error.va.gen.01":"不完全なフィールド","error.va.gen.02":"フィールドが無効です","error.va.sf-cc-num.01":"カード番号が無効です","error.va.sf-cc-num.03":"サポートされていないカードが入力されました","error.va.sf-cc-dat.01":"カードが古すぎます","error.va.sf-cc-dat.02":"未来の日付が先すぎです","error.giftcard.no-balance":"このギフトカードの残高はゼロです","error.giftcard.card-error":"記録では、この番号のギフトカードはありません","error.giftcard.currency-error":"ギフトカードは、発行された通貨でのみ有効です。","amazonpay.signout":"Amazonからサインアウトする","amazonpay.changePaymentDetails":"支払明細を変更する","partialPayment.warning":"残金を支払う別の支払方法を選択してください","partialPayment.remainingBalance":"残りの残高は%{amount}になります","bankTransfer.beneficiary":"受益者","bankTransfer.iban":"IBAN","bankTransfer.bic":"BIC","bankTransfer.reference":"参照","bankTransfer.introduction":"新しい銀行振込によるお支払の作成を続行します。次の画面の詳細を使用して、このお支払いを確定できます。","bankTransfer.instructions":"お買い上げありがとうございます。以下の情報を使用して、お支払いを完了してください。","bacs.accountHolderName":"銀行口座名義","bacs.accountHolderName.invalid":"銀行口座名義が無効です","bacs.accountNumber":"銀行口座番号","bacs.accountNumber.invalid":"銀行口座番号が無効です","bacs.bankLocationId":"ソートコード","bacs.bankLocationId.invalid":"ソートコードが無効です","bacs.consent.amount":"上記の金額が私の銀行口座から引き落とされることに同意します。","bacs.consent.account":"口座が私の名義であることを確認し、この口座からの自動引き落としを承認するために必要な唯一の署名者であることを確認します。",edit:"編集","bacs.confirm":"確認して支払う","bacs.result.introduction":"自動引き落としの説明 (DDI/委任状) をダウンロードする","download.pdf":"PDFをダウンロード","creditCard.encryptedCardNumber.aria.iframeTitle":"保護されたカード番号の iframe","creditCard.encryptedCardNumber.aria.label":"カード番号フィールド","creditCard.encryptedExpiryDate.aria.iframeTitle":"保護されたカードの有効期限日の iframe","creditCard.encryptedExpiryDate.aria.label":"有効期限日フィールド","creditCard.encryptedExpiryMonth.aria.iframeTitle":"保護されたカードの有効期限月の iframe","creditCard.encryptedExpiryMonth.aria.label":"有効期限月フィールド","creditCard.encryptedExpiryYear.aria.iframeTitle":"保護されたカードの有効期限年の iframe","creditCard.encryptedExpiryYear.aria.label":"有効期限年フィールド","creditCard.encryptedSecurityCode.aria.iframeTitle":"保護されたカードのセキュリティコードの iframe","creditCard.encryptedSecurityCode.aria.label":"セキュリティコードフィールド","giftcard.encryptedCardNumber.aria.iframeTitle":"保護されたギフトカード番号の iframe","giftcard.encryptedCardNumber.aria.label":"ギフトカード番号フィールド","giftcard.encryptedSecurityCode.aria.iframeTitle":"保護されたギフトカードのセキュリティコードの iframe","giftcard.encryptedSecurityCode.aria.label":"ギフトカードのセキュリティコードフィールド",giftcardTransactionLimit:"このギフトカードでの取引ごとに許可される最大%{amount}","ach.encryptedBankAccountNumber.aria.iframeTitle":"保護された銀行口座番号の iframe","ach.encryptedBankAccountNumber.aria.label":"銀行口座フィールド","ach.encryptedBankLocationId.aria.iframeTitle":"保護された銀行支店番号の iframe","ach.encryptedBankLocationId.aria.label":"銀行支店番号フィールド"}}}]);