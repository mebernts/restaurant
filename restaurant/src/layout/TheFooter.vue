<template>
    <footer>
        <h3>Footer</h3>
        <ul>
            <li v-for="footer in footerinfo" :key="footer.contactinfo">
                {{footer.adress}}
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