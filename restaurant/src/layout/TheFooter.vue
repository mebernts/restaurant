<template>
    <footer id="footer" class="blue-grey darken-3">
        <h3 class="footerText">Footer</h3>
        <ul>
            <li v-for="footer in footerinfo" :key="footer.contactinfo">
            </li>
        </ul>
        
    </footer>
</template>

<script>
import FooterStore from '@/Stores/FooterStore.js'
export default {
    name: "TheFooter",
    data(){
        return{
            footerinfo: FooterStore.getFooterinfo
        }
    }
}
</script>

<style scoped>
.footerText{
    color: white;
}

#footer{
    height: 100px;
}
</style>