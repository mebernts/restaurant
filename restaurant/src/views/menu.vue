<template>
    <div>
        <h1>This the menu</h1>
        <AppertizerList/>
        <DishList/>
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
