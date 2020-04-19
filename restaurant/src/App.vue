<template>
<v-app>
  <link href="https://fonts.googleapis.com/css2?family=Dancing+Script&family=Lora:ital,wght@1,400;1,500&display=swap" rel="stylesheet">
  <div id="app">
    <TheNavigation/>
    <router-view/>
  </div>
  </v-app>
</template>
<script>
import TheNavigation from './layout/TheNavigation.vue'
export default {
   name: 'App',
    components: {
      TheNavigation
    } 
}
</script>