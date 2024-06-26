import './assets/main.css'
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
const app = createApp(App)

import 'vue-virtual-scroller/dist/vue-virtual-scroller.css'
import VueVirtualScroller from 'vue-virtual-scroller'
app.use(VueVirtualScroller)

import { Language } from "@/i18n/i18n";
const i18n = new Language().i18n;
app.use(i18n);

app.use(router)
app.mount('#app')