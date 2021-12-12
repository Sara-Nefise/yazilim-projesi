const { Builder, By, Key, until } = require('selenium-webdriver');

(async function example() {
    let driver = await new Builder().forBrowser('firefox').build();

    await driver.get('http://127.0.0.1:8080');
    //anasayıfada bulunan city buttonun testi
    //await driver.findElement(By.xpath('//*[@id="q-app"]/div/div/main/div[2]/div/div[1]/label/div/div/div[1]')).click();
    //await driver.findElement(By.xpath('/html/body/div/div/div/main/div[2]/div/div[1]/label/div/div/div[1]/div[1]/input')).sendKeys('istanbul', Key.ENTER);

    // arama buttonun testi
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div[1]/div/div[3]/div/div[2]/label/div/div/div[1]')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div[1]/div/div[3]/div/div[2]/label/div/div/div[1]/input')).sendKeys('ayasofya', Key.ENTER);
    //await driver.wait(1000);

})();