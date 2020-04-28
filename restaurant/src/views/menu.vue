<template>
    <div>
       <h1 class="black--text  text-center">Our menu</h1>
        <h2>Appetizers</h2>
        <AppertizerList/>
        <h2>Dishes</h2>
        <DishList/>
        <h2>Drinks</h2>
        <DrinkList/>
    </div>
</template>

<script>
import AppertizerList from '@/components/AppertizerList.vue'
import DishList from '@/components/DishList.vue'
import DrinkList from '@/components/DrinkList.vue'
export default {
    name: 'menu',
    components:{
        AppertizerList,
        DishList,
        DrinkList
    }
}
</script>
