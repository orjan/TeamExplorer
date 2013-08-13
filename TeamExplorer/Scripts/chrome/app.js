function load() {
    chrome.windows.create({ url: 'http://www.google.com', type: 'panel' });
}
document.getElementsByTagName('body')[0].onload = function () { load(); };