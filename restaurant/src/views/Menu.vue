<template>
    <div>
       <h1 class="black--text  text-center">Meny</h1>
        <h2>Forretter </h2>
        <AppertizerList/>
        <h2>Hovedretter</h2>
        <DishList/>
        <h2>Drikke</h2>
        <DrinkList/>
    </div>
</template>

<script>
import AppertizerList from '@/components/AppertizerList.vue'
import DishList from '@/components/DishList.vue'
import DrinkList from '@/components/DrinkList.vue'
export default {
    name: 'Menu',
    components:{
        AppertizerList,
        DishList,
        DrinkList
    }
}
</script>
