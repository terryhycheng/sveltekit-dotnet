<script lang="ts">
	import type { PageData } from './$types';

	export let data: PageData;
</script>

<h1>Todo List from .NET Core</h1>

{#each data.todos as todo}
	<div class="container">
		<h2>{todo.task}</h2>
		{#if todo.isCompleted}
			<p>Completed</p>
		{:else}
			<p>Not Completed</p>
		{/if}
	</div>
{/each}

<style>
	.container {
		display: flex;
		align-items: center;
		gap: 1rem;
	}
</style>
