const {test, expect} = require('@playwright/test');

test('Test if User can add a Task', async ({page}) =>{
    await page.goto('http://localhost:5500/');
    await page.fill('#task-input', "Test Task");
    await page.click('#add-task');

    const taskEl = await page.textContent('.task');
    expect(taskEl).toContain('Test Task');

});

test('Test if user can delete a Task', async ({page}) =>{
    await page.goto('http://localhost:5500/');
    await page.fill('#task-input', "Test Task");
    await page.click('#add-task');

    await page.click('.delete-task');
    const testTasks = await page.$$eval('.task', tasks => tasks.map(task => task.textContent));

    expect(testTasks).not.toContain('Test Task');
});

test('Test if user can mark task as complete', async ({page}) =>{
    await page.goto('http://localhost:5500/');
    await page.fill('#task-input', "Test Task");
    await page.click('#add-task');

    await page.click('.task-complete');
    const completedTask = await page.$('.task.completed');

    expect(completedTask).not.toBeNull();
});

test('Test if tasks can be filtered', async ({page}) =>{
    await page.goto('http://localhost:5500/');
    await page.fill('#task-input', "Test Task");
    await page.click('#add-task');

    await page.click('.task .task-complete');

    await page.selectOption('#filter', 'Completed');

    const taskItems =await page.$('.task:not(.completed)');

    expect(taskItems).toBeNull();
})