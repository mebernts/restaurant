<template>
    <div>
        <h1>This the menu</h1>
        <AppertizerItem/>
        <DishItem/>
        <DrinkItem/>
    </div>
</template>

<script>
import AppertizerItem from '@/components/AppertizerItem.vue'
import DishItem from '@/components/DishItem.vue'
import DrinkItem from '@/components/DrinkItem.vue'
export default {
    name: 'menu',
    components: {
      AppertizerItem,
      DishItem,
      DrinkItem
    } 
    
}
</script>