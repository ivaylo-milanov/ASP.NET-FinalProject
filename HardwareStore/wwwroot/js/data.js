﻿export async function sendFilterData(ev, data) {
    const path = ev.currentTarget.dataset.url;
    const html = await request.post(path, data);

    const container = ev.currentTarget.dataset.container;
    document.querySelector(container).innerHTML = html;
}