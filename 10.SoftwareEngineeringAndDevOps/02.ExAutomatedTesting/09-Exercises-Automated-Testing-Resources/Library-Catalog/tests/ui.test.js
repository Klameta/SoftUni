const { test, expect } = require("@playwright/test");

test("Is /All Books/ link visible?", async ({ page }) => {
  await page.goto("http://localhost:3000");
  const button = await page.$('a[href="/catalog"]');
  const isLinkVisible = await button.isVisible();

  expect(isLinkVisible).toBe(true);
});

test("IS /Login/ button visible", async ({ page }) => {
  await page.goto("http://localhost:3000");
  const button = await page.$('a[href="/login"]');
  const isBtnVisible = await button.isVisible();

  expect(isBtnVisible).toBe(true);
});

test("Is /Register/ button visible", async ({ page }) => {
  await page.goto("http://localhost:3000");
  const button = await page.$('a[href="/register"]');
  const isButtonVisible = await button.isVisible();

  expect(isButtonVisible).toBe(true);
});

test("is /All Books/ button visible after logging in", async ({ page }) => {
  await page.goto("http://localhost:3000/login");
  await page.fill("#email", "aaa@aaa.com");
  await page.fill("#password", "aaaa");
  await page.click("input.button.submit");

  const button = await page.$('a[href="/catalog"]');
  const isLinkVisible = await button.isVisible();

  expect(isLinkVisible).toBe(true);
});

test('Is /My Books/ visible after logging in', async ({page})=>{
    await page.goto("http://localhost:3000/login");
    await page.fill("#email", "aaa@aaa.com");
    await page.fill("#password", "aaaa");
    await page.click("input.button.submit");

    const button = await page.$('a[href="/profile"]');
    const isBtnVisible = await button.isVisible();

    expect(isBtnVisible).toBe(true);
})

test('Is users email visible after logging in', async ({page})=>{
    await page.goto("http://localhost:3000/login");
    await page.fill("#email", "aaa@aaa.com");
    await page.fill("#password", "aaaa");
    await page.click("input.button.submit");

    const email = await page.$('#user span');
    const isEmailVisible = await email.isVisible();

    expect(isEmailVisible).toBe(true);
})

test('Is user able to log in with correct credentials', async ({page})=>{
    await page.goto("http://localhost:3000/login");
    await page.fill("#email", "aaa@aaa.com");
    await page.fill("#password", "aaaa");
    await page.click("input.button.submit");

    await page.$('a[href="/catalog"]');
    const pageUrl = await page.url();
    expect(pageUrl).toBe("http://localhost:3000/catalog")
});

test('Is user able to log in with empty credentials', async ({page})=>{
    await page.goto("http://localhost:3000/login");
    await page.click("input.button.submit");

    page.on('dialog', async dialog =>{
        expect(dialog.type()).toContain('alert');
        expect(dialog.message()).toContain("All fields are required!");
        await dialog.accept();
    })

    await page.$('a[href="/login"]');
    const pageUrl = await page.url();
    expect(pageUrl).toBe("http://localhost:3000/login")
});
test('Is user able to log in with empty email', async ({page})=>{
    await page.goto("http://localhost:3000/login");
    await page.fill("#email", "aaa@aaa.com");
    await page.click("input.button.submit");

    page.on('dialog', async dialog =>{
        expect(dialog.type()).toContain('alert');
        expect(dialog.message()).toContain("All fields are required!");
        await dialog.accept();
    })

    await page.$('a[href="/login"]');
    const pageUrl = await page.url();
    expect(pageUrl).toBe("http://localhost:3000/login")
});
test('Is user able to log in with empty password', async ({page})=>{
    await page.goto("http://localhost:3000/login");
    await page.fill("#password", "aaaa");
    await page.click("input.button.submit");

    page.on('dialog', async dialog =>{
        expect(dialog.type()).toContain('alert');
        expect(dialog.message()).toContain("All fields are required!");
        await dialog.accept();
    })

    await page.$('a[href="/login"]');
    const pageUrl = await page.url();
    expect(pageUrl).toBe("http://localhost:3000/login")
});

test('Is user able to register in with correct credentials', async ({page})=>{
        await page.goto("http://localhost:3000/register");
        await page.fill("#email", "bbbbdbd@bbb.bbb");
        await page.fill("#password", 'bbbb');
        await page.fill("#repeat-pass", 'bbbb');
        await page.click("input.button.submit");
    
        await page.$('a[href="/catalog"]');
        const pageUrl = await page.url();
        expect(pageUrl).toBe("http://localhost:3000/catalog")
    });