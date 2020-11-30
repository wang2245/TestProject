import Vue from 'vue';
import VueRouter from 'vue-router'
import routers from './router.js'
import ElementUI from 'element-ui'
import 'element-ui/lib/theme-chalk/index.css'
import App from './App.vue';

Vue.config.productionTip = true;

Vue.use(ElementUI);
Vue.use(VueRouter);

new Vue({
    render: h => h(App)
}).$mount('#app');
