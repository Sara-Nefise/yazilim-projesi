const { Builder, By, Key, until } = require('selenium-webdriver');

(async function example() {
    let driver = await new Builder().forBrowser('firefox').build();

    //first test
    await driver.get('http://127.0.0.1:8080');
    //more information button ve back button testi
    /*await driver.findElement(By.xpath('/html/body/div/div/div/main/div[2]/div/div[2]/div[1]/div/div[3]/a')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/a')).click();
    await driver.wait(2000);*/

    //form test
    //anasayifa
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div[2]/div/div[1]/a/span[2]')).click();
    //place name
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[1]/div/div[1]/div')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[1]/div/div[1]/div/input')).sendKeys('Ayasofya', Key.RETURN);

    //phone number
    // 
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[2]/div/div[1]/div[1]')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[2]/div/div[1]/div[1]/input')).sendKeys('537350000', Key.RETURN);
    //Email
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[2]/div/div[1]/div[1]')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[3]/div/div[1]/div[1]/input')).sendKeys('test1@gmail.com', Key.RETURN);

    //price
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[4]/div/div[1]/div')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[4]/div/div[1]/div/input')).sendKeys('15', Key.RETURN);

    //opening time
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[4]/div/div[1]/div')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[5]/div/div[1]/div/input')).sendKeys('9', Key.RETURN);

    //closing time
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[6]/div/div[1]/div')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[6]/div/div[1]/div/input')).sendKeys('19', Key.RETURN);

    //image url
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[2]/div/label[1]/div/div[1]/div')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[2]/div/label[1]/div/div[1]/div[1]/input'))
        .sendKeys('https://media-cdn.t24.com.tr/media/library/2020/06/1591855878989-ayasofya.jpg', Key.RETURN);

    // description
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[2]/div/label[2]/div/div[1]/div[1]')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[2]/div/label[2]/div/div[1]/div[1]/textarea'))
        .sendKeys('Tarihi bir yarımada içinde Fatih ilçesine bağli bulunan Sultanahmet meydaninda yer alan Ayasofya, İstanbul da yapilmiş olan en büyük Bizans kilisesi niteliğini taşimaktadir.Ayni bölümde tam üç defa inşa edilmiştir.İlk yapildiği dönem içerisinde Megale Ekklesia adini almiştir.', Key.RETURN);
    //

    //address
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[5]/div/div[1]/div')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[8]/div/div[1]/div[1]/textarea')).sendKeys('Fatih İstanbul Türkiye', Key.RETURN);

    /*city
    await driver.findElement(By.xpath('/html/body/div[1]/div/div/main/div/form/div[1]/div[1]/div/label[7]/div/div/div[1]')).click();
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[1]/div[1]/div/label[8]/div/div[1]/div[1]/textarea')).sendKeys('g', Key.ENTER);*/

    //add button
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[2]/button/span[2]')).click();
    //back button
    await driver.findElement(By.xpath('/html/body/div/div/div/main/div/form/div[2]/a')).click();
    await driver.wait(3000);
    await driver.quit();
})();